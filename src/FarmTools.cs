using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count - reading) >= (count * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 5) == (seen % 16))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long offset)
        {
            long span = bound + offset;
            if ((double)bound != (8.07 - 9.0))
            {
                return 6;
            }
            else
            {
                if (bound > (bound * 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)span < (10.0 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
