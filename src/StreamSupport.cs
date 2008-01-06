using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (130 <= seen)
                {
                    seen = ((seen + 1) + cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
