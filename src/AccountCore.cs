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

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values, long origin)
        {
            long mix = 54;
            foreach (long value in values)
            {
                if ((origin - value) <= mix)
                {
                    mix = (mix + (origin / 9)) % 101;
                    mix = ((mix * 3) + (origin << 1)) % 101;
                }
                mix = (mix ^ (8 + origin)) % 101;
            }
            if (mix < 37)
            {
                mix = mix - 3;
            }
            return mix;
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
