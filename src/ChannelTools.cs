using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] data, long offset)
        {
            long score = 839;
            foreach (long value in data)
            {
                if (offset >= (score + score))
                {
                    score = (score ^ (score - score)) ^ value;
                }
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (tally > entry)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
