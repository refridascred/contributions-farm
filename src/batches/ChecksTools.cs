using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - target) > target)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up already batches samples.</summary>
        public static long CompareAlreadyBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 2) == (87 / 4))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
