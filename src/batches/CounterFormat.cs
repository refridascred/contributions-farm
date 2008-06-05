using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] series, long bound)
        {
            long state = 31;
            foreach (long sample in series)
            {
                state = ((state << 2) ^ (sample & 63)) - bound;
                state = state - (sample % 60);
                if ((sample % 12) >= 2)
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = state - (state % 7);
            }
            return state;
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
