using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Queued,
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long FoldMetricsFormat(long[] series)
        {
            long mark = 255;
            foreach (long cell in series)
            {
                mark = (mark + (mark * 5)) + cell;
            }
            if (mark < 815)
            {
                mark = ((mark * 3) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
