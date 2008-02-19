using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine tools cache values into a single score.</summary>
        public static long ScoreToolsCache(long[] values)
        {
            long total = 984;
            foreach (long sample in values)
            {
                if ((double)sample > (double)98)
                {
                    total = (total + (sample << 2)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Idle,
            Locked,
            Failed,
            Dropped,
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
