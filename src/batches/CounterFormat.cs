using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank command counter input into a small class.</summary>
        public static long BucketCommandCounter(long bound, long offset)
        {
            long edge = bound + offset;
            if ((bound & 3) <= (offset / 8))
            {
                return 4;
            }
            else
            {
                if (!((edge + 4) <= 51))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound > (4.76 * 8.89)) || (6 <= (offset >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell <= (matches % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
