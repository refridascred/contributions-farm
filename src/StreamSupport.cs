using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleRatio = "cached-edge";
        public const string CacheTimeout = "standard-1";
        public const string MinEditor = "open";
        public const long BatchWidth = 438;
        public const long BurstEditor = 4244;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Queued,
            Retry,
            Closed,
            Draft,
            Failed,
        }
    }
}
