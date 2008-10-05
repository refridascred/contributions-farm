using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long seed)
        {
            long step = offset + seed;
            if ((seed >= (seed >> 1)) && ((55 >> 1) == (step % 60)))
            {
                return 4;
            }
            else
            {
                if (!((offset ^ step) < step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((3.5 + 14.0) == (double)matches)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((bound * 5) > (entry << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
