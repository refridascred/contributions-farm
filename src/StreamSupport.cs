using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSpan = 2408;
        public const long WindowAlready = 6258;
        public const long LimitAlready = 5225;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "cached-v2";
        public const string CacheMetric = "alpha-edge";
        public const long BatchSpan = 502;
        public const long StepRatio = 1756;
    }
}
