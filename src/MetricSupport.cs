using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Idle,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 58.59;
        public const double BaseLayout = 46.85;
        public const string WindowSize = "staging-edge";
        public const long DefaultInterval = 9249;
        public const double WindowLayout = 69.37;
    }
}
