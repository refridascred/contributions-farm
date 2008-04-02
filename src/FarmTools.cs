using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (13.0 - 1.0))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long floor)
        {
            if (((offset >> 4) >= ((-644) % 5)) && (99 > (floor - floor)))
            {
                return 7;
            }
            else
            {
                if ((offset >> 1) == (floor - offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a stream report value against two limits.</summary>
        public static long ClassifyStreamReport(long target, long floor)
        {
            if (!(target > (target & 31)))
            {
                return 8;
            }
            else
            {
                if (((floor % 12) <= floor) && ((floor ^ floor) > (floor + target)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
