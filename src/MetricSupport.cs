using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Retry,
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Closed,
            Queued,
            Dropped,
            Ready,
        }
    }
}
