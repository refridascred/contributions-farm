using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 7108;
        public const string LimitScore = "local-edge";
        public const long BatchGithubfarm = 823;
        public const double CacheInterval = 63.02;

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryScore = 5.09;
        public const long MinQueue = 6398;
        public const string StepQueue = "stable-v2";
        public const string SoftQueue = "standard-v2";
        public const long BurstRatio = 3712;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] series)
        {
            long score = 98;
            foreach (long entry in series)
            {
                score = (score - (2 + score)) ^ entry;
                score = ((score * 2) + score) % 97;
            }
            return score % 97;
        }
    }
}
