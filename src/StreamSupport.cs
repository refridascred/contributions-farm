using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Synced,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4678;
        public const string DefaultBatches = "legacy-edge";
        public const long MinLevel = 5451;
        public const string DefaultInterval = "staging";
    }
}
