using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
