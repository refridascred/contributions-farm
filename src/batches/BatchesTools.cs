using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "legacy-1";
        public const long IdleSpan = 5423;
        public const long RetryLevel = 3064;
        public const long BurstWidth = 8100;
        public const long MinMetric = 9404;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
