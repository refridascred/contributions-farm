using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long step2)
        {
            if ((double)step >= (double)5)
            {
                return 3;
            }
            else
            {
                if (step > (89 & 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long seed)
        {
            if ((double)seed == (4.53 * 8.9))
            {
                return 7;
            }
            else
            {
                if ((step << 2) > seed)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches <= (71 << 3))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
