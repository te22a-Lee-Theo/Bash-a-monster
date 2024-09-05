Megaman rock = new Megaman()  {
    Name = "Rockman",
    Hitpoints = 100,
    Attackdmg = 10,
};

Enemy ice = new Enemy()    {
    Name = "Iceman",
    Hitpoints = 100,
    Attackdmg = 10,
};

System.Console.WriteLine("Welcome to the arena");
System.Console.WriteLine("Today we're going to witness the fight between Rockman and Iceman");

while (rock.Hitpoints > 0 || ice.Hitpoints > 0)
{
    System.Console.WriteLine($"Rockman hp:{rock.Hitpoints}  Iceman hp:{ice.Hitpoints}");
    Console.ReadLine();

    ice.Hitpoints -= rock.Attackdmg;
    System.Console.WriteLine($"Rockman hits Iceman and deals {rock.Attackdmg}");

    rock.Hitpoints -= ice.Attackdmg;
    System.Console.WriteLine($"Iceman swings at Rockman and deals {ice.Attackdmg}");

}

System.Console.WriteLine($"Rockman hp:{rock.Hitpoints}  Iceman hp:{ice.Hitpoints}");

if (rock.Hitpoints == 0 && ice.Hitpoints > 0)
{
    System.Console.WriteLine("Iceman wins");
}
else if (ice.Hitpoints == 0 && rock.Hitpoints > 0)
{
    System.Console.WriteLine("Rockman wins");
}
else if (ice.Hitpoints == 0 && rock.Hitpoints == 0)
{
    System.Console.WriteLine("It's a draw");
}


Console.ReadLine();