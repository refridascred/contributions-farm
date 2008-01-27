using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Draft,
            Idle,
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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
