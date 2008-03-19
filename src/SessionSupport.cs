using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double scale, double bias)
        {
            double drift = (double)(1 - 6);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)50) + (double)(long)i;
            }
            return drift - (bias - scale);
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - 53) > (sample & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank support metrics input into a small class.</summary>
        public static long SortSupportMetrics(long seed, long step)
        {
            if (!((step * 2) < seed))
            {
                return 6;
            }
            else
            {
                if (((seed ^ step) >= seed) || (0.77 > (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((2.8 / 9.0) != (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
