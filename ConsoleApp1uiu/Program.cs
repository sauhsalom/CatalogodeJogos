using System;
using System.Collections.Generic;
using System.ComponentModel;

class Jogo
{
    public Jogo(string nome, string genero, int ano)
    {
        Nome = nome;
        Genero = genero;
        Ano = ano;
    }

    public string Nome { get; set; }
    public string Genero { get; set; }
    public int Ano { get; set; }
}

class CatalogoJogos
{
    private List<Jogo> Jogos { get; set; }
    public bool CatalogoVazio => Jogos.Count == 0;

    public CatalogoJogos()
    {
        Jogos = new List<Jogo>();
    }

    public void AdicionarJogo(string nome, string genero, int ano)
    {
        Jogo novoJogo = new Jogo(nome, genero, ano);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");
    }

    public void ListarJogos()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catálogo de jogos está vazio.");
        }
        else
        {
            Console.WriteLine("Catálogo de jogos: ");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano: {jogo.Ano}.");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        CatalogoJogos catalogo = new CatalogoJogos();

        catalogo.AdicionarJogo("The Witcher 3", "RPG", 2015);
        catalogo.AdicionarJogo("Cyberpunk 2077", "RPG", 2020);

        catalogo.ListarJogos();
    }
}