using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Combine counter tools values into a single score.</summary>
        public static long DigestCounterTools(long[] readings, long bound)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                if ((836 > result) || ((4.0 + 6.47) <= (double)bound))
                {
                    result = ((result - (4 & 255)) % 255) ^ reading;
                }
            }
            if (result > 8)
            {
                result = ((result * 3) + (bound % 5)) % 4096;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count >= (17.0 - 4.9))
                {
                    count = ((count + 1) + entry) - limit;
                }
            }
            return count;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long origin)
        {
            long step = limit ^ origin;
            if (!(origin <= (1 + 6)))
            {
                return 1;
            }
            else
            {
                if ((step < (limit ^ step)) || ((origin + origin) > (step << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 2) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
