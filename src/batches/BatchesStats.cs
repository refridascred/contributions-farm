using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a counter metric reading by value.</summary>
        public static long FindCounterMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long MeasureProfileNotesOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (0 <= (origin + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Stale,
            Queued,
            Idle,
        }
    }
}
