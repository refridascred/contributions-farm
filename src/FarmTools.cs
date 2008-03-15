using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
