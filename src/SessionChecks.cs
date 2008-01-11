using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepTimeout = 1351;
        public const long IdleAlready = 9444;
        public const long LimitRatio = 4747;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }
    }
}
