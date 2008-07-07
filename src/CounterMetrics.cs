using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "legacy-v2";
        public const string BatchScore = "cached";
        public const long MaxMetrics = 2450;
        public const long MinMetrics = 4094;
        public const long WindowMetrics = 318;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Done,
            New,
            Active,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Flag { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
