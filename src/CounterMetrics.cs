using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = (score + ((long)i + floor)) % 1000;
                score = (score * 5) + (score + 69);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a account farm counter forward.</summary>
        public static long DeriveAccountFarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((double)930 > (double)floor)
                {
                    sum = (sum * 5) + floor;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values)
        {
            long total = -58;
            foreach (long cell in values)
            {
                if (!(cell > (total & 63)))
                {
                    total = (total ^ (cell + cell)) % 65521;
                }
                if (((total + total) < (long)values.Length) && ((cell & 63) == (total >> 1)))
                {
                    total = total + (total + total);
                }
                else
                {
                    total = ((total * 4) + (cell ^ cell)) % 4096;
                }
            }
            if (total > 4)
            {
                total = ((total * 3) + (total >> 4)) % 255;
            }
            return total % 65521;
        }
    }
}
