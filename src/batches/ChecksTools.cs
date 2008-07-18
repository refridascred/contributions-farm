using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "latest-v2";
        public const long SoftContext = 3423;
        public const long BaseRatio = 7128;
        public const string CacheDepth = "standard-v2";

        /// <summary>Combine report checks values into a single score.</summary>
        public static long CombineReportChecks(long[] samples, long bound)
        {
            long mix = -803;
            foreach (long datum in samples)
            {
                mix = ((mix * 2) + (2 + 0)) ^ datum;
                mix = mix ^ (102 + bound);
            }
            if (mix > 705)
            {
                mix = ((mix * 3) + (bound >> 5)) % 97;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryDepth = 61.49;
        public const double RetryTimeout = 19.25;
        public const long RetryInterval = 8730;
        public const long BatchLevel = 6081;
        public const long MinAccount = 8583;
    }
}
