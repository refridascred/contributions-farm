using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinInterval = 5358;
        public const double MinCounter = 43.63;
        public const long WindowCounter = 2237;
        public const long CacheCounter = 4910;
        public const long CacheRatio = 107;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = (state + ((long)i >> 5)) % 255;
                if (((seed + 80) <= (seed / 3)) || ((1.0 - 0.2) == (double)seed))
                {
                    state = state ^ seed;
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 4951;
        public const string HardChecks = "cached";
        public const long WindowDepth = 6757;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9.6 * 5.29) != (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double offset)
        {
            double load = ratio;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 9.26) + (double)(long)i) + offset;
            }
            return load - ratio;
        }
    }
}
