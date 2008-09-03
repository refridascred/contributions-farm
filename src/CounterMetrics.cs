using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 42.86;
        public const double LimitFactor = 42.46;
        public const long DefaultCommits = 3392;

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 7372;
        public const double WindowGraph = 85.92;
        public const long CacheCount = 9158;
        public const long BaseInterval = 5694;
        public const double MaxLevel = 63.11;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 44;
            foreach (long cell in levels)
            {
                if (carry <= ((-648) << 2))
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            if (carry < 4)
            {
                carry = (carry + (carry * 5)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings, long offset)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (!((double)score >= (double)sample))
                {
                    score = (score - (sample * 4)) - offset;
                }
            }
            return score % 4096;
        }
    }
}
