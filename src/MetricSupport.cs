using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Closed,
            Done,
            Idle,
            Stale,
        }
    }
}
