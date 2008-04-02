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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long offset)
        {
            if (((double)bound < (1.4 / 3.0)) && ((bound >> 4) >= (bound ^ 36)))
            {
                return 0;
            }
            else
            {
                if (offset <= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
