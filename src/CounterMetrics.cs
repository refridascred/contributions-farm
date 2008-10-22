using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 80.72;
        public const string MinDepth = "fallback-1";
        public const double CacheAlready = 47.09;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "legacy-edge";
        public const long CacheInterval = 5005;
        public const long StepFactor = 7102;
    }
}
