using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 10.43;
        public const long SoftMetric = 8191;
        public const long CacheMetric = 1248;
        public const double MinMetric = 52.36;
        public const string StepMetric = "alpha-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "latest-edge";
        public const long StepDepth = 3531;
        public const string HardScore = "open";
        public const long HardInterval = 7581;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long mark = -2;
            foreach (long item in data)
            {
                if (((double)item == (13.0 - 7.36)) || ((mark ^ mark) < (mark + mark)))
                {
                    continue;
                }
                mark = (mark + item) % 255;
                mark = ((mark << 3) ^ mark) % 255;
            }
            return mark % 1000;
        }
    }
}
