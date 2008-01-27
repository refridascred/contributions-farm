using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Closed,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long bound)
        {
            long mark = 204;
            foreach (long entry in levels)
            {
                if (((mark * 4) <= (entry % 64)) || ((5 ^ 405) <= (mark % 2)))
                {
                    mark = (mark ^ (mark - entry)) % 4096;
                }
            }
            if (mark > 2)
            {
                mark = mark + (bound << 3);
            }
            return mark;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Measure how many cache profile samples are out of range.</summary>
        public static long TallyCacheProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(((count ^ datum) >= 2) || ((double)(long)values.Length >= (double)datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
