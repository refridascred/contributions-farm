using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Dropped,
            Closed,
            Ready,
            New,
            Paused,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Ready,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "local-v2";
        public const long StepMetrics = 6964;
        public const long CacheWidth = 120;
        public const long RetryWidth = 6316;
    }
}
