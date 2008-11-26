using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Draft,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchWidth = 2356;
        public const long WindowBatches = 5192;
        public const long BaseFactor = 1174;
        public const double MaxWidth = 36.36;
        public const long IdleBatches = 5028;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 8098;
        public const long IdleMetrics = 7890;
        public const long LimitMetrics = 4121;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
