using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + count) <= (cell - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((offset % 60) == (matches + offset))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long seed)
        {
            long offset = bound - seed;
            if ((offset < (offset % 2)) || ((offset + seed) != (seed + 6)))
            {
                return 1;
            }
            else
            {
                if ((13.0 + 16.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
