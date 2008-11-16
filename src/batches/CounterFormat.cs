using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseSpan = 5224;
        public const long MinChecks = 4656;
        public const long CacheDepth = 5972;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long origin)
        {
            long score = 93;
            foreach (long cell in series)
            {
                if (((2.62 * 3.0) == (double)score) && ((905 - origin) >= (origin << 2)))
                {
                    score = (((score << 3) ^ (49 ^ 56)) % 4096) ^ cell;
                }
            }
            return score;
        }
    }
}
