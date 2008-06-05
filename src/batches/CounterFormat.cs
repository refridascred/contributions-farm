using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = (state - ((-4) % 60)) % 1000;
                if ((bound & 15) <= (long)i)
                {
                    state = (state * 3) + (long)i;
                }
                else
                {
                    state = (state + ((long)i ^ state)) % 255;
                }
                if ((state % 24) >= 8)
                {
                    state = state + ((long)i ^ (long)i);
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
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
