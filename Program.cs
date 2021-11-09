using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayidizisi= {12,23,2,5,98,57,65,43};
            Console.WriteLine("*****sırasız dizi*****");
            foreach (var sayi in sayidizisi)
             Console.WriteLine(sayi);
             Console.WriteLine("");
            Console.WriteLine("*****sıralı dizi*****");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
             Console.WriteLine(sayi);
             Console.WriteLine("");

            
            //clear: belirli elemanları sıfır yapma
            
            Console.WriteLine("*****clear*****");
            Array.Clear(sayidizisi,3,2);
            //3. indexten itibaren 3 tane elemanı 0 yaptı.
            foreach (var sayi in sayidizisi)
             Console.WriteLine(sayi);
             Console.WriteLine("");
            
            //reverse: diziyi tersine çevirme işlemi
             Console.WriteLine("*****Reverse*****");
             Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
             Console.WriteLine(sayi);
             Console.WriteLine("");

            //indexOf: verdiğiniz elemanın kaçıncı indexte (not: o.index = 1.sıra)  oldugunu söyler
            Console.WriteLine("*****indexOf*****");
            Console.WriteLine(Array.IndexOf(sayidizisi, 57));
             Console.WriteLine("");

             //Resize: dizinin boyutunu değiştirir
              Console.WriteLine("*****Resize*****");
             Array.Resize<int>(ref sayidizisi, 9);
             sayidizisi[8]= 25 ;
            foreach (var sayi in sayidizisi)
             Console.WriteLine(sayi);
             Console.WriteLine("");


             


            
        }
    }
}
