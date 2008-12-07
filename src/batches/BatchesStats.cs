using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Queued,
            Active,
        }

        /// <summary>Measure how many batches stream samples are out of range.</summary>
        public static long CountBatchesStreamHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (hits < entry)
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
