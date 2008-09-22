using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 8460;
        public const long IdleGraph = 9554;
        public const long MaxScore = 1303;
        public const long LimitGraph = 2306;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Closed,
            Queued,
            Draft,
        }
    }
}
