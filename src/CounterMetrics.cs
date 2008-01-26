using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryDepth = "fallback-edge";
        public const long DefaultFactor = 8922;
        public const long SoftTools = 61;

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 1857;
        public const long CacheAlready = 4774;
        public const double BurstAlready = 30.24;
        public const long BatchAlready = 2210;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinSize = 92.46;
        public const long SoftCache = 9702;
        public const long MinLevel = 7177;
        public const double IdleCache = 68.32;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Dropped,
            Ready,
        }
    }
}
