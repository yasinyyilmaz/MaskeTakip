﻿using Business.Concrete;
using Entities.Concrete;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            SelamVer(isim:"Yasin");
            SelamVer(isim:"Yılmaz");
            SelamVer(isim:"Ahmet");
            SelamVer();
            int sonuc = Topla(3,5);

            string ogrenci1 = "Yasin";
            string ogrenci2 = "Mehmet";
            string ogrenci3 = "Ali";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Yasin";
            ogrenciler[1] = "Mehmet";
            ogrenciler[2] = "Ali";

            ogrenciler = new string[4];
            ogrenciler[3] = "Ahmet";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Antalya", "Bursa", "Çanakkale" };
            sehirler2 = sehirler1;
            sehirler1[0]= "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Yasin";
            person1.LastName = "Yılmaz";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Ahmet";

            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item:"Adana 1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }
        static void SelamVer(string isim="isminiz")
        {
            Console.WriteLine("Merhaba "+isim);
        }
        static int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc.ToString());
            return sonuc;
        }
    }
}