using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long ScoreGithubfarmToken(long[] levels)
        {
            long mark = -135;
            foreach (long item in levels)
            {
                mark = (((mark * 2) + (mark / 5)) % 65521) + item;
            }
            if (mark > 565)
            {
                mark = ((mark << 3) ^ (mark ^ 208)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            Paused,
            Active,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8207;
        public const double BaseDepth = 56.31;
        public const long BaseLayout = 2592;

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstFactor = "stable-edge";
        public const string WindowCache = "local-edge";
        public const double LimitTimeout = 96.69;
    }
}
