using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!!((double)target > 7.6))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] levels, long origin)
        {
            long acc = 59;
            foreach (long value in levels)
            {
                acc = ((acc * 3) + (acc / 8)) % 255;
                if (((origin % 5) != (value + origin)) && (75 <= acc))
                {
                    acc = ((acc * 4) + (value + value)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Failed,
            Locked,
            New,
        }
    }
}
