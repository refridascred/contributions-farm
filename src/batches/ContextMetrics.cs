using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Paused,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "primary";
        public const string BurstCount = "cached-v2";
        public const double StepContext = 57.66;
        public const long CacheContext = 2548;
    }
}
