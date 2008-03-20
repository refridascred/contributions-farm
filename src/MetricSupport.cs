using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches - datum) != (matches << 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long limit)
        {
            if (origin > (634 % 5))
            {
                return 8;
            }
            else
            {
                if ((limit ^ origin) != (limit / 3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long offset)
        {
            if ((target << 1) <= (target / 5))
            {
                return 1;
            }
            else
            {
                if ((double)offset >= (2.35 * 1.4))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
