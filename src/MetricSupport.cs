using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 2234;
        public const string IdleCount = "strict-edge";
        public const long BatchEntry = 3934;
        public const long CacheBudget = 3191;
        public const string SoftCount = "primary";

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
