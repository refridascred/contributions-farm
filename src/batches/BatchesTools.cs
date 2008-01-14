using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "alpha-v2";
        public const long StepWidth = 5685;
        public const long CacheRatio = 8700;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long target)
        {
            long acc = 56;
            foreach (long datum in items)
            {
                acc = (acc - (target + 74)) ^ datum;
            }
            if (acc > 94)
            {
                acc = acc + ((long)items.Length % 64);
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "alpha-1";
        public const long DefaultCount = 869;
        public const double MinFactor = 2.58;
        public const string DefaultFactor = "primary-1";
        public const double HardCommits = 53.06;
    }
}
