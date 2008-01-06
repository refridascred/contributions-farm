using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Derive the next queue metrics value from a seed.</summary>
        public static long RollQueueMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 4) + (origin * 5);
                long bound = (anchor * 5) + (origin + anchor);
                if (((295 >> 3) > anchor) || (8 < (bound ^ bound)))
                {
                    anchor = ((anchor * 2) + ((-913) ^ bound)) % 97;
                    continue;
                }
                else
                {
                    anchor = anchor + ((long)i + 2);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((seed + count) > (count >> 1)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
