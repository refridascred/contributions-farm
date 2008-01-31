using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Ready,
            Synced,
            New,
            Pending,
        }

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long CountGraphFilterGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((35 >> 2) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
