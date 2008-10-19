using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            Failed,
            Draft,
            New,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 1953;
        public const long HardFactor = 5560;
        public const double MaxMetric = 10.2;
        public const long HardMetric = 6773;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits != (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long bound)
        {
            if ((8.0 * 2.0) != (double)bound)
            {
                return 7;
            }
            else
            {
                if (((1.4 * 1.0) >= (double)bound) && (offset > (offset % 64)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
