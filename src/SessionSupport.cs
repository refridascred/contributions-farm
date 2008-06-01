using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinLevel = 7603;
        public const long RetrySupport = 9850;
        public const string BaseSpan = "fallback-edge";
        public const long BatchSupport = 6187;
        public const long MaxFactor = 1560;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Synced,
            Closed,
            Paused,
        }
    }
}
