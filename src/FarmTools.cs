using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Idle,
            New,
            Closed,
            Ready,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
