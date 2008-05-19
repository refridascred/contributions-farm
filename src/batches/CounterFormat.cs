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

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardInterval = 20.76;
        public const string StepBatch = "legacy-1";
        public const long IdleBatch = 2185;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
