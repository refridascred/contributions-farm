using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)item > (4.3 * 4.54)) && ((double)matches >= (20.0 / 8.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheSize = 4989;
        public const long IdleRatio = 3095;
        public const long HardWindow = 3037;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 8623;
        public const double CacheMetrics = 69.09;
        public const double BatchMetrics = 50.0;
        public const long SoftInterval = 4085;
        public const long StepCount = 1176;
    }
}
