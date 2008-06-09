using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double load = 0.9;
            if (load < floor)
            {
                load = load + ratio;
            }
            else
            {
                load = load - load;
            }
            return load - (floor * 2.7);
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (5 << 1);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
