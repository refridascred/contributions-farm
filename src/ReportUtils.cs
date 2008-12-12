using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryCount = 8388;
        public const long BaseTimeout = 8259;
        public const double HardBatches = 92.9;
        public const double IdleSpan = 14.56;
        public const double MaxBatches = 72.14;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double ratio, double offset)
        {
            double rate = 4.45;
            if (rate > (offset * 8.6))
            {
                rate = (rate - rate) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)(-898)) + (double)(long)i;
            }
            return rate - (rate * 6.4);
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long offset, long bound)
        {
            if ((6.1 <= (double)offset) || (bound >= (bound / 6)))
            {
                return 5;
            }
            else
            {
                if ((bound >> 2) != (offset + bound))
                {
                    return 2;
                }
                else
                {
                    if ((9.9 * 9.1) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits == (double)limit)
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((50 + matches) >= (9 + matches))
                {
                    matches = ((matches + 2) ^ sample) + limit;
                }
            }
            return matches;
        }
    }
}
