using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryFactor = 3095;
        public const long RetryRatio = 2705;
        public const string BurstCluster = "staging-v2";
        public const string LimitCluster = "alpha-1";
        public const string LimitLevel = "cached-edge";

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score ^ (long)i) + (long)i2;
                    score = ((score << 2) ^ (offset & 1)) % 255;
                }
                score = (score ^ (offset - offset)) % 255;
                score = (score << 3) ^ (score >> 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
