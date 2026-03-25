using System;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var food = 5;
            //var comensales = new int[] { 3, 1, 2, 1, 5 };
            //var comensales = new int[] { 3, 5, 2, 1 }
            //var comensales = new int[] { 1, 3, 5, 1 };
            var comensales = new int[] { 3, 1, 2, 1 };

            var grupos = comensales.Chunk(2).ToList();

            var diferencias = new List<int>();

            var newArray = new List<int>();

            foreach (var grupo in grupos)
            {
                //diferencias.Add(grupo[0] - grupo[1]);
                diferencias.Add(grupo.ElementAtOrDefault(0) - grupo.ElementAtOrDefault(1));

                Console.WriteLine($"Grupo: {string.Join(", ", grupo)}");
            }

            diferencias.OrderDescending();

            //while (food > 0)
            //{
            //    for (int i = 0; i < diferencias.Count; i++)
            //{
            //var diferencia = diferencias[i];

            for (int j = 0; j < grupos.Count(); j++)
            {
                var max = Math.Max(grupos[j].ElementAtOrDefault(0), grupos[j].ElementAtOrDefault(1));
                var min = Math.Min(grupos[j].ElementAtOrDefault(0), grupos[j].ElementAtOrDefault(1));

                //var affected = grupos[j].Where(x => x == max).FirstOrDefault();

                var index = Array.IndexOf(grupos[j].ToArray(), max);

                var difference = max - min;

                //food -= difference;
                int toRemove = Math.Min(food, difference);
                food -= toRemove;

                newArray.Insert(j * 2, 0);
                newArray.Insert(j * 2 + index, toRemove);


                Console.WriteLine($"index: {index} + group:" + j);

                //}


                //si es el indice 0 del grupo, tiene q ser 0 o 1
                // si es el indice 1 del grupo tiene q ser 2 o 3
                // si es el indice 2 del grupo, tiene q ser 4 o 5

            }


            foreach (var item in newArray)
            {
                Console.WriteLine($"new array: {item}");

            }
        }
    }

}