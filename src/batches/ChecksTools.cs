using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)limit != (15.0 * 17.0)))
                {
                    mix = ((mix * 5) + (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double bias = 3.73;
            if (bias >= (double)5)
            {
                bias = (bias - (bias - bias)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (13.0 - bias)) + (double)(long)i;
            }
            return bias + (bias - gain);
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state + (long)i)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "alpha-v2";
        public const double CacheMetric = 87.28;
        public const string CacheWidth = "strict-v2";
        public const long BaseBudget = 4356;
    }
}
