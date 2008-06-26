using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if ((36 + (-6)) < score)
                {
                    score = ((score * 3) + (score >> 3)) ^ value;
                }
            }
            return score;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long bound)
        {
            long anchor = 327;
            foreach (long entry in levels)
            {
                if ((6 ^ bound) == (anchor << 1))
                {
                    anchor = ((anchor - (bound + 95)) % 255) - entry;
                }
                if (anchor <= (anchor - 0))
                {
                    break;
                }
            }
            if (anchor < 23)
            {
                anchor = ((anchor << 2) ^ 811) % 255;
            }
            return anchor;
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
