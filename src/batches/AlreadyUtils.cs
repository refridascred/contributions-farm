using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up entry window samples.</summary>
        public static long OverlapEntryWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)matches >= (6.63 - 7.23))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster payload samples.</summary>
        public static long CombineClusterPayload(long[] items, long bound)
        {
            long mix = 26;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ (72 ^ sample)) + bound;
            }
            return mix % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value >= (854 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
