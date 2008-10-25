using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxWidth = "fallback";
        public const long RetryCluster = 8602;
        public const double CacheCount = 44.53;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Failed,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 76.62;
        public const long DefaultRatio = 2733;
        public const double BaseFilter = 35.57;
        public const string SoftFactor = "fallback-v2";
        public const double WindowWidth = 21.98;
    }
}
