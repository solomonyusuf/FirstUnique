int[] s = { 1, 4, 3, 3, 1, 2 };
Solution(s);

int Solution(int[] A)
{
    var value = 0;
    var duplicate = A.GroupBy(x => x).Where(d => d.Count() == 1);
    if (duplicate.Any())
    {
        var a = duplicate.ToArray();
        var res = a.First().Key;
        return res += value;
    }
    else
    {
        return -1;
    }

}

