using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Compare every pair of already booking readings.</summary>
        public static long MatchAlreadyBookingCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] items)
        {
            long result = 98;
            foreach (long value in items)
            {
                result = result - (22 * 2);
                result = (result ^ result) % 1000;
                result = ((result << 3) ^ (value - (-9))) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Synced,
            Idle,
            Done,
            Active,
        }
    }
}
