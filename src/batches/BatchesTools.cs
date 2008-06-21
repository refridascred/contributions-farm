using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Retry,
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value == (19.0 * 1.0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
