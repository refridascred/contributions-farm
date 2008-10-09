using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Stale,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
