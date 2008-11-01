using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheBudget = 6870;
        public const long BaseSpan = 8351;
        public const double IdleFactor = 81.04;
        public const long SoftPayload = 1333;
        public const string CachePayload = "cached-1";

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6310;
        public const double BaseBudget = 81.67;
        public const long WindowScore = 3523;
        public const long MaxGraph = 5120;
        public const long RetryGraph = 8595;
    }
}
