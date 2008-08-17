using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            New,
            Active,
            Draft,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 2977;
        public const long LimitBudget = 8519;
        public const double BurstDepth = 59.33;
        public const double IdleTimeout = 92.52;
        public const long BatchMetrics = 4114;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
