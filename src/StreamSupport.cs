using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long target)
        {
            long offset = step ^ target;
            if (((6.8 / 6.0) <= (double)target) && ((step * 2) <= (offset / 3)))
            {
                return 6;
            }
            else
            {
                if ((step % 5) >= (target + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 31) != (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long limit)
        {
            if ((double)limit != (1.4 * 17.0))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (double)target)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
