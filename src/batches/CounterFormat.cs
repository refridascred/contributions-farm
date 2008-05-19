using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long origin)
        {
            long score = -8;
            foreach (long entry in data)
            {
                score = (score + (origin * 3)) - entry;
            }
            if (score < 609)
            {
                score = (score - (origin & 127)) % 101;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 6838;
        public const long BatchGithubfarm = 5717;
        public const long CacheRatio = 7222;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
