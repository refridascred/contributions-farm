using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < (double)67)
            {
                weight2 = (weight2 + (double)(-45)) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (weight - weight2)) + (double)(long)i;
            }
            return weight2 + 5.37;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((double)hits != (1.6 - 10.0)) && ((target / 6) == ((-19) - hits))))
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
