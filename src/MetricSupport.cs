using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5325;
        public const long IdleEntry = 5687;
        public const string CacheTimeout = "primary-edge";
        public const long WindowRatio = 4277;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Token { get; set; }
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
