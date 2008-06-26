using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleInterval = 6450;
        public const double CacheStats = 79.95;
        public const string RetryStats = "primary";
        public const long DefaultInterval = 2319;
        public const long RetryLevel = 7168;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)seed == (1.78 * 0.6)))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinRatio = "legacy";
        public const long WindowBatch = 3432;
        public const double CacheBatch = 85.86;
        public const double RetryBatch = 34.1;
    }
}
