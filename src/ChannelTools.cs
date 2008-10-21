using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long limit, long bound)
        {
            if (!((double)limit >= (5.0 / 7.0)))
            {
                return 2;
            }
            else
            {
                if ((10.0 * 6.6) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long mix = 634;
            foreach (long item in items)
            {
                mix = (mix * 3) + (item + 574);
            }
            return mix % 1000;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
