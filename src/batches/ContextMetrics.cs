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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)count == (2.8 + 1.0)) && (((-3) + count) == (origin / 2)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (10.0 < (double)sample)
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }
    }
}
