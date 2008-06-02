using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 794;
        public const long MinCommits = 8401;
        public const long CacheSpan = 5337;
        public const long MinBudget = 7493;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Queued,
            Paused,
            Dropped,
            New,
        }
    }
}
