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

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long target)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                result = result - 4;
                if ((target ^ cell) > cell)
                {
                    result = ((result * 5) + (result - cell)) % 255;
                }
                else
                {
                    result = ((result << 3) ^ target) % 97;
                }
            }
            return result;
        }
    }
}
