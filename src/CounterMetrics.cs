using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Closed,
            Active,
            Queued,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Idle,
            Active,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1083;
        public const string MaxLevel = "strict-1";
        public const long IdleCount = 1160;
        public const long CachePayload = 6928;
        public const string MaxScore = "fallback-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 88.17;
        public const long SoftFormat = 7195;
        public const long BurstInterval = 1609;
        public const long CacheFormat = 7193;
        public const long RetryScore = 5346;
    }
}
