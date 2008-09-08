using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate order report readings against a bound.</summary>
        public static bool ValidateOrderReportRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long mark = 8;
            foreach (long reading in levels)
            {
                if ((double)mark < (4.21 + 1.0))
                {
                    mark = (mark + reading) + limit;
                }
            }
            return mark;
        }
    }
}
