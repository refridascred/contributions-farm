using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - 1) < (item - item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter command value against two limits.</summary>
        public static long RankCounterCommand(long seed, long origin)
        {
            if (3.0 < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((origin << 3) > (seed + 802))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
