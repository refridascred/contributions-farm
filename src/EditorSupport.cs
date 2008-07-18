using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3472;
        public const long IdleBatch = 1494;
        public const long MinDepth = 7527;
        public const long MinBatch = 1297;
        public const long WindowTimeout = 1602;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Done,
            Synced,
            Failed,
            Draft,
        }
    }
}
