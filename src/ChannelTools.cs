using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long limit)
        {
            long mark = 51;
            foreach (long reading in values)
            {
                mark = (mark ^ (mark + limit)) + reading;
            }
            return mark % 4096;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (offset < tally)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already token entries.</summary>
        public static long FoldAlreadyToken(long[] items, long limit)
        {
            long score = 64;
            foreach (long datum in items)
            {
                score = (score - (limit + score)) - datum;
            }
            return score % 4096;
        }
    }
}
