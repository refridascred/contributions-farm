using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Token { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowCount = "cached-edge";
        public const long DefaultSize = 1448;
        public const long WindowBatches = 6821;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryWidth = 8979;
        public const string DefaultChecks = "stable";
        public const string StepFactor = "fallback-edge";
        public const string BatchFactor = "fallback-edge";
        public const long BatchChecks = 5054;
    }
}
