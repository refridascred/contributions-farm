using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseDepth = 2345;
        public const long LimitGraph = 7953;
        public const long LimitLevel = 4543;
        public const long WindowGraph = 161;

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
