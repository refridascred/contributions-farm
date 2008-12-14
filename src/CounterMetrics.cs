using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 59.59;
        public const string WindowBatch = "strict";
        public const long HardBatch = 9767;
        public const double DefaultWidth = 60.36;
    }
}
