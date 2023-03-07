using System;
using System.Text;

namespace Pergunta5;

class Program
{
    /*Escreva um programa que inverta os caracteres de um string.
    IMPORTANTE:
    a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

    b) Evite usar funções prontas, como, por exemplo, reverse;*/

    static void Main(string[] args)
    {
        Console.WriteLine("Oi! Digite uma palavra e eu vou escreve-la ao contrario.");

        string crescente = Console.ReadLine();
        //string crescente = "123456789";

        StringBuilder decrescente = new StringBuilder();

        //Foi colocado o modificador -1 porque no caso, 
        //o ultimo caractere fica na posicao 0 (zero).
        for(var i = crescente.Length-1; i >= 0; i--)
        {
            decrescente.Append(crescente[i]);
        }
        //Console.Write(crescente.Length);

        Console.WriteLine("Veja como ela fica quando escrita de tras para frente! ");
        Console.WriteLine(decrescente.ToString());
        
        Console.WriteLine("Ok! Para sair, basta apertar uma tecla.");
        Console.ReadKey();

    }


}