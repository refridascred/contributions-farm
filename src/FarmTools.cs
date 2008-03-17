using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Retry,
            Done,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Failed,
            Idle,
        }
    }
}
