using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] values, long origin)
        {
            long mix = 29;
            foreach (long reading in values)
            {
                mix = ((mix << 2) ^ (origin + reading)) % 255;
                mix = mix ^ reading;
                mix = mix ^ (5 + 894);
            }
            if (mix < 80)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix;
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
