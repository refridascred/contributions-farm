using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "cached-edge";
        public const double BatchBudget = 66.78;
        public const double IdleEditor = 66.93;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Synced,
            Paused,
        }
    }
}
