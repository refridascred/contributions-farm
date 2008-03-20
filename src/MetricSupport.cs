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

        /// <summary>Accumulate profile record samples.</summary>
        public static long TallyProfileRecord(long[] data, long bound)
        {
            long mark = -30;
            foreach (long entry in data)
            {
                if ((double)entry <= (9.07 / 7.0))
                {
                    mark = ((mark << 3) ^ (entry + 116)) % 97;
                }
                else
                {
                    mark = mark - (8 << 1);
                }
            }
            if (mark < 1)
            {
                mark = ((mark << 2) ^ (bound >> 5)) % 255;
            }
            return mark;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - ((long)i + limit);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
