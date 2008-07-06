using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] items)
        {
            long acc = 38;
            foreach (long reading in items)
            {
                acc = (acc - (acc + acc)) % 4096;
                if ((reading ^ acc) > reading)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (93 < (bound >> 5))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long target)
        {
            long lane = limit - target;
            if (0.52 > (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)lane == (7.0 * 0.37))
                {
                    return 3;
                }
                else
                {
                    if ((5.2 - 1.0) >= (double)lane)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
