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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
