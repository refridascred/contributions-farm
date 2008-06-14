using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowWidth = "fallback-edge";
        public const double MaxTimeout = 65.32;
        public const double DefaultFactor = 6.0;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Pending,
            Done,
            Queued,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Done,
            Ready,
            New,
            Paused,
        }
    }
}
