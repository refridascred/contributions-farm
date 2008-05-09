using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long seed, long seed2)
        {
            long next = seed ^ seed2;
            if ((double)next < (14.0 * 5.8))
            {
                return 8;
            }
            else
            {
                if (6.7 <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 6716;
        public const string IdleInterval = "stable-1";
        public const long CacheChecks = 6250;
        public const long StepBudget = 2685;
        public const string BaseChecks = "cached-v2";

        /// <summary>Blend two filter record measurements.</summary>
        public static double ProjectFilterRecord(double ratio, double bias)
        {
            double rate = ratio;
            return (rate - ratio) + bias;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 2) + (747 / 7);
                if (((double)state > (8.7 * 5.9)) || ((947 / 8) > ((long)i / 7)))
                {
                    state = (state << 3) ^ state;
                    state = ((state * 5) + ((long)i >> 5)) % 65521;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
