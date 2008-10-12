using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cluster profile input into a small class.</summary>
        public static long GradeClusterProfile(long bound, long step)
        {
            long gap = bound ^ step;
            if ((3.5 + 9.39) < (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((8.7 * 10.0) >= (4.87 - 1.0)))
                {
                    return 6;
                }
                else
                {
                    if (gap >= (4 ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series)
        {
            long score = 287;
            foreach (long item in series)
            {
                if (((score % 60) < (item + item)) && ((double)item == (4.97 + 0.24)))
                {
                    score = (score * 4) + item;
                }
            }
            return score;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long floor)
        {
            long state = 79;
            foreach (long cell in items)
            {
                if (((double)cell > (double)(-902)) && ((30 >> 3) > (cell - floor)))
                {
                    state = (state ^ 84) % 4096;
                }
                if ((7.5 * 8.8) >= (double)state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
