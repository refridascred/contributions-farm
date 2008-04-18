using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Draft,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Paused,
            Stale,
        }
    }
}
