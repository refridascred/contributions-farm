using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Queued,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Flag { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
