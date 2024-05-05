using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 45, 52, 78, 93 };
            int kucuk, orta, buyuk, aradigimsayi = 45;
            kucuk = 0;
            buyuk = sayilar.Length - 1;
            while (kucuk <= buyuk)
            {
                orta = (kucuk + buyuk) / 2;
                if (aradigimsayi == sayilar[orta])
                {
                    Console.WriteLine("Aradığım sayı dizinin {0} . elemanı", orta);
                    break;
                }
                else if (aradigimsayi < sayilar[orta])
                {
                    buyuk = orta - 1;
                }
                else
                {
                    kucuk = orta + 1;
                }
            }
            Console.ReadLine();
        }
    }
}
