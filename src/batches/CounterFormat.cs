using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up order filter samples.</summary>
        public static long CompareOrderFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long limit, long bound)
        {
            if ((bound - 582) < limit)
            {
                return 0;
            }
            else
            {
                if (((bound - bound) != (1 & 1)) && ((2.89 * 6.7) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a buffer window value against two limits.</summary>
        public static long SortBufferWindow(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((2 % 2) >= (640 - bound))
            {
                return 4;
            }
            else
            {
                if ((diff - seed) > (352 * 2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
