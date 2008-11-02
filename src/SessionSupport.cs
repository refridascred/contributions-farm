using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed * 3) < (count % 7))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor - step;
                anchor = ((anchor * 2) + (109 + anchor)) % 255;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long SortStatsSession(long seed, long seed2)
        {
            long bound = seed - seed2;
            if ((8.2 - 6.6) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (seed2 < (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if ((3.99 / 5.0) < (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
