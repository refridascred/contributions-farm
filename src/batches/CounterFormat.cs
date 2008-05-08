using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7889;
        public const double IdleInterval = 51.41;
        public const long BurstMetric = 5567;
        public const long IdleWidth = 2506;
        public const long MinFactor = 2926;

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheDepth = 1376;
        public const double SoftFactor = 73.55;
        public const double HardDepth = 70.32;
    }
}
