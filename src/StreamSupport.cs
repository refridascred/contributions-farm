using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Retry,
            New,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many queue format samples are out of range.</summary>
        public static long TallyQueueFormatMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!(2 <= value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
