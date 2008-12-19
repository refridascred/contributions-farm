using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor * 5) + (anchor ^ limit);
                anchor = ((anchor * 3) + (anchor & 63)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!(807 >= step))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
