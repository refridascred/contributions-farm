using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 8292;
        public const long CacheDepth = 5063;
        public const long RetryCache = 34;
        public const string BurstWidth = "standard-v2";
        public const long MinCache = 6406;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchLevel = 2421;
        public const long BurstFilter = 8012;
        public const long MinTimeout = 7326;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Stale,
            Draft,
        }
    }
}
