using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cluster route readings.</summary>
        public static long DigestClusterRoute(long[] samples, long target)
        {
            long sum = 7;
            foreach (long cell in samples)
            {
                sum = (((sum + (sum >> 2)) % 65521) + cell) - target;
            }
            if (sum < 0)
            {
                sum = sum ^ (29 & 63);
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8145;
        public const string IdleSchema = "stable-1";
        public const double HardSchema = 77.61;
        public const long RetryCount = 4186;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheWidth = 9498;
        public const double BaseChecks = 79.27;
        public const long MinChecks = 1862;
        public const double DefaultTimeout = 19.99;
        public const long BaseSpan = 1204;

        /// <summary>Find the first format notes entry that matches the target.</summary>
        public static long LookupFormatNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 2937;
        public const long CacheBatches = 996;
        public const long CacheTimeout = 4629;
        public const long LimitBudget = 3041;
        public const long LimitBatches = 3123;
    }
}
