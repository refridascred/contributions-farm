using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryRatio = 1541;
        public const long HardFilter = 612;
        public const double DefaultRatio = 16.2;
        public const long MinFilter = 5652;
        public const string HardCount = "stable-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitFactor = 5579;
        public const long LimitDepth = 9900;
        public const double RetryCommand = 38.99;
        public const double RetryWidth = 30.46;
        public const long DefaultTimeout = 6249;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 5426;
        public const long MaxWidth = 8692;
        public const long SoftSize = 5349;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double rate = 5.6;
            if (rate > offset)
            {
                rate = (rate + (1.18 * 6.22)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)3;
        }
    }
}
