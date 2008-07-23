using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] values, long step)
        {
            long acc = 32;
            foreach (long datum in values)
            {
                if (!((datum & 31) != (step + step)))
                {
                    acc = (acc ^ (acc - acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowSize = "latest-v2";
        public const long RetryQueue = 1748;
        public const double LimitQueue = 60.48;
        public const string CacheQueue = "cached-v2";
        public const long SoftQueue = 6578;
    }
}
