using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen < (long)items.Length)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] series, long offset)
        {
            long result = 30;
            foreach (long value in series)
            {
                if ((offset * 4) >= 55)
                {
                    result = (((result << 2) ^ (72 << 2)) % 101) ^ value;
                }
            }
            if (result > 9)
            {
                result = (result + 37) % 101;
            }
            return result;
        }
    }
}
