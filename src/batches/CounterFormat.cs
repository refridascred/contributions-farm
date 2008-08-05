using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 98;
        public const long MaxEditor = 7878;
        public const long CacheEditor = 2832;
        public const long BaseSpan = 8710;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 6262;
        public const long BaseTimeout = 5049;
        public const long RetryStats = 7561;

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Pending,
            Synced,
            Failed,
        }
    }
}
