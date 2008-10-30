using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a record support value against two limits.</summary>
        public static long GradeRecordSupport(long step, long offset)
        {
            if (!((5.4 * 1.0) > (double)step))
            {
                return 0;
            }
            else
            {
                if (((0.1 * 1.36) != (double)step) || (1 > (offset ^ step)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank commits token input into a small class.</summary>
        public static long RankCommitsToken(long floor, long origin)
        {
            if (floor > (floor + 24))
            {
                return 2;
            }
            else
            {
                if (floor < (32 * 4))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items)
        {
            long total = 6;
            foreach (long cell in items)
            {
                if (((total + total) <= (cell << 2)) || ((cell - cell) >= (cell >> 3)))
                {
                    total = ((total * 5) + (cell + total)) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
