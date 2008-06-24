using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7172;
        public const long RetryMetrics = 8554;
        public const long RetryWidth = 392;
        public const long HardMetrics = 2865;
        public const long HardInterval = 59;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Closed,
            Paused,
            Locked,
            Ready,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Failed,
            Queued,
            Active,
        }
    }
}
