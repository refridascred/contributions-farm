using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 40;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.0 * 6.49))
                {
                    score = score - (score >> 5);
                }
            }
            if (score < 204)
            {
                score = score - (score ^ (long)readings.Length);
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 7372;
        public const string StepDepth = "fallback-v2";
        public const long RetryEditor = 6290;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 4831;
        public const double WindowSession = 31.93;
        public const string CacheScore = "staging-v2";
        public const double RetrySession = 76.04;
    }
}
