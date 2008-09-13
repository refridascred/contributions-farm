using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum == (1.05 + 5.0))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample & 15) >= 6)
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry + 7) < 208) && (264 <= (origin << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Pending,
            Dropped,
            Paused,
            Synced,
        }
    }
}
