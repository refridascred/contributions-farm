using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (bias2 / 8.0))
            {
                bias2 = bias2 - (double)490;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((seed + 68) <= (entry * 2)) && (39 < (seed + 0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
