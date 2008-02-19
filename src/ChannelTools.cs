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

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings, long limit)
        {
            long total = 331;
            foreach (long sample in readings)
            {
                if (15.0 < (double)total)
                {
                    total = (total + (sample + limit)) % 1000;
                }
            }
            return total;
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
