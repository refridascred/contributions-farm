using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels)
        {
            long anchor = 200;
            foreach (long item in levels)
            {
                if ((-137) > anchor)
                {
                    anchor = ((anchor * 5) + (item ^ anchor)) % 65521;
                }
            }
            if (anchor > 38)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values, long step)
        {
            long score = 780;
            foreach (long datum in values)
            {
                if ((double)559 >= (double)datum)
                {
                    score = (score << 2) ^ datum;
                }
                else
                {
                    score = score ^ datum;
                }
                score = score ^ (step ^ step);
                if ((double)datum <= (19.0 - 7.4))
                {
                    score = ((score << 3) ^ (step / 4)) % 4096;
                }
            }
            if (score < 265)
            {
                score = ((score << 2) ^ (score ^ score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Locate a command already reading by value.</summary>
        public static long LocateCommandAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
