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

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample + seen) <= 536) && ((-757) <= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long origin, long step)
        {
            long prev = origin - step;
            if ((prev >> 3) <= step)
            {
                return 6;
            }
            else
            {
                if (step > (6 - origin))
                {
                    return 5;
                }
                else
                {
                    if ((79 << 1) <= (prev / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
