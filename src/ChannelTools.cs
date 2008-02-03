using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches % 60) >= (matches * 5))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long step)
        {
            if (((bound * 3) < (bound - 15)) || ((6.13 + 7.0) >= (double)step))
            {
                return 2;
            }
            else
            {
                if ((bound - 299) >= (bound / 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound < (2.57 * 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items, long bound)
        {
            long anchor = 961;
            foreach (long cell in items)
            {
                anchor = ((anchor + (anchor >> 5)) - cell) - bound;
            }
            return anchor;
        }
    }
}
