using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinTimeout = 33.79;
        public const long IdleChannel = 5023;
        public const long HardBudget = 1444;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Dropped,
            Stale,
            Failed,
        }
    }
}
