using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitDepth = 83.85;
        public const string LimitInterval = "staging";
        public const double StepInterval = 50.62;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Active,
            Idle,
            Paused,
            New,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Draft,
            Active,
            Dropped,
        }
    }
}
