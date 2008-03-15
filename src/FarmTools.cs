using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "primary";
        public const long SoftSupport = 9944;
        public const string WindowSpan = "fallback-v2";
        public const double IdleSupport = 84.88;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 175;
            foreach (long value in values)
            {
                if (!((value << 1) >= (score / 6)))
                {
                    score = ((score * 3) + (score + score)) % 1000;
                }
                if (value >= (score << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheDepth = 8232;
        public const long RetryStream = 4622;
        public const long StepStream = 3533;
    }
}
