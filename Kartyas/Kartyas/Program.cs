// See https://aka.ms/new-console-template for more information
/*  •	Egy kártyalap a francia kártyában rendelkezik színnel (treff, káró, kör, pikk) és értékkel (2, 3, 4, 5, 6, 7, 8, 9, 10,
        J, D, K, A). Egy csomag kártya 52 lapból áll. Készítsen osztó programot, mely egy ilyen csomag kártyából adott
        számú (legfeljebb 4) játékosnak kioszt adott számú (legfeljebb 20) lapot.
        (Megjegyzés: A kiosztott lapok számának és a játékosok számának szorzata természetesen nem lehet nagyobb
        mint 52, illetve osztáskor a lapok nem ismétlődhetnek.)                                                                     */


using System.Runtime.CompilerServices;

Random r = new Random();

List<string> playerA = new List<string>();
List<string> playerB = new List<string>();
List<string> playerC = new List<string>();
List<string> playerD = new List<string>();

int playerCount = r.Next(1,5);

List<string> deck = new List<string>() {
    "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As",
    "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
    "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
    "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac" 
};

int deckSize = 52;

int dealtCards;

switch (playerCount)
{
    case 4:
        dealtCards = r.Next(1, 14);
        break;
    case 3:
        dealtCards = r.Next(1, 18);
        break;
    default:
        dealtCards = r.Next(1, 21);
        break;  
}

for (int i = 0; i < dealtCards; i++)
{
    int helper;
        switch (playerCount)
        {
            case 4:
                helper = r.Next(0, deckSize);
                playerA.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);

                helper = r.Next(0, deckSize);
                playerB.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);

                helper = r.Next(0, deckSize);
                playerC.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);

                helper = r.Next(0, deckSize);
                playerD.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);
            break;

            case 3:
                helper = r.Next(0, deckSize);
                playerA.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);

                helper = r.Next(0, deckSize);
                playerB.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);

                helper = r.Next(0, deckSize);
                playerC.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);
            break;

            case 2:
                helper = r.Next(0, deckSize);
                playerA.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);

                helper = r.Next(0, deckSize);
                playerB.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);

                helper = r.Next(0, deckSize);
                playerC.Add(deck[helper]);
                deckSize--;
                deck.Remove(deck[helper]);
            break;
        }
}

// ellenőrzés:
Console.Write("1. játékos lapjai: ");
foreach (string card in playerA)
{
    Console.Write(card + " ");
}
Console.WriteLine();

Console.Write("\n2. játékos lapjai: ");
foreach (string card in playerB)
{
    Console.Write(card + " ");
}
Console.WriteLine();

if (playerCount == 3)
{
    Console.Write("\n3. játékos lapjai: ");
    foreach (string card in playerC)
    {
        Console.Write(card + " ");
    }
    Console.WriteLine();
}
else if (playerCount == 4)
{
    Console.Write("\n3. játékos lapjai: ");
    foreach (string card in playerC)
    {
        Console.Write(card + " ");
    }
    Console.WriteLine();

    Console.Write("\n4. játékos lapjai: ");
    foreach (string card in playerD)
    {
        Console.Write(card + " ");
    }
}

// megjegyzés: siker, de azért na... :D az aktuális tudásommal problem solved, de túl hosszúnak érzem. 

// felmerült a kérdés: mennyire "szintfelmérő" ez. Azaz attól függően, hogyan oldom meg a feladatot, tudsz majd irányt mutatni, hol/merre fejlődjek, vagy már most szánjam rá az időt és keressem
// a jobb megoldást? (persze alapvetően igyekszem, de van ami nextlevel megoldásként egyelőre sok időnek tűnik utánajárni és ugye kvázi találgatok, hogy mi lehet jobb/egyszerűbb megoldás






