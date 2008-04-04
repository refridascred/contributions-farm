using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetrySize = "alpha";
        public const long LimitScore = 3539;
        public const long IdleRecord = 1513;

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultInterval = "strict";
        public const long RetryInterval = 9559;
        public const long BaseCommand = 9322;
        public const long BaseDepth = 741;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Closed,
            Done,
            Active,
            Retry,
        }
    }
}
