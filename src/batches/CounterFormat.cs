using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples)
        {
            long result = -6;
            foreach (long entry in samples)
            {
                result = ((result * 4) + result) - entry;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long seed2)
        {
            long next = seed + seed2;
            if (((6.2 - 5.5) != (double)seed2) && ((double)next < (0.9 + 0.4)))
            {
                return 6;
            }
            else
            {
                if ((seed * 3) != (next + seed2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double drift = scale;
            if (drift >= (double)(-542))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (drift + drift)) + (double)(long)i;
            }
            return drift - (drift + scale);
        }
    }
}
