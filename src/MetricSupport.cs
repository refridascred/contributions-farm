using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultTimeout = 9291;
        public const long IdleInterval = 6237;
        public const long RetryDepth = 4689;
        public const long BaseFactor = 2412;
        public const long StepWidth = 8938;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheCount = 8218;
        public const long RetrySchema = 3629;
        public const double StepDepth = 96.13;
        public const long BurstLevel = 3866;

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
