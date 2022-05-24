using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1) Crie um array com 10 posições e imprima os valores em ordem decrescente até o numero 0;
               2)Crie um array que receba numeros inteiros e mostre na tela quantos 
                numeros positivos e numeros negativos o array possui;
             */

            int[] n = new int[10]; //Int[], define que é um Array
            int positivo = 0;
            int negativo = 0;
            // Define i = 0, Enquanto i menor que a quantidade de posições do Array "n" faça, i++ o i é acressido +1.
            for (int i = 0; i < n.Length; i++)  
            {
                Console.WriteLine("Digite um numero: ");
                n[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Você digitou o indice " + i +  " de " + n.Length + " posições.");
                if (n[i] > 0)
                {
                    Console.WriteLine("Numero positivo");
                    positivo = positivo + 1;
                }
                else
                {
                    Console.WriteLine("é negativo");
                    negativo = negativo + 1;
                }

            }
            
            Console.WriteLine("Numeros pares: " + par);
            Console.WriteLine("Numeros impares: " + impar);

        }
    }
}
