using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double offset)
        {
            double mean = ratio - 1.57;
            return (mean - (mean / 8.0)) + offset;
        }

        /// <summary>Audit cluster already readings against a rule.</summary>
        public static long AuditClusterAlreadyGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((double)offset <= (double)reading) && (hits > offset))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowSize = "stable-1";
        public const string WindowMetrics = "alpha";
        public const long BurstMetrics = 5260;
        public const string BatchSize = "stable-edge";
    }
}
