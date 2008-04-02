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

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long result = -5;
            foreach (long value in items)
            {
                result = (result ^ (value * 3)) % 255;
                if ((7 * 4) != (result / 4))
                {
                    result = (result << 2) ^ (value + result);
                }
            }
            if (result > 0)
            {
                result = result ^ (result << 2);
            }
            return result % 4096;
        }
    }
}
