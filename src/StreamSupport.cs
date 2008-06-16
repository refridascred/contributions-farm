using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long sum = 81;
            foreach (long cell in levels)
            {
                sum = ((sum * 2) + 41) ^ cell;
            }
            return sum;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.13 - 5.3) >= (double)cell)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheSpan = "open-v2";
        public const double LimitCluster = 82.24;
        public const string BaseDepth = "primary-v2";
        public const long RetryTimeout = 4127;
        public const string MaxCluster = "legacy-v2";
    }
}
