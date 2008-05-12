using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxScore = "staging-1";
        public const long RetryRatio = 8442;
        public const long BaseStats = 9765;
        public const long SoftStats = 539;
        public const long WindowStats = 7582;

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftInterval = "fallback-1";
        public const long BaseSize = 8139;
        public const double IdleToken = 49.19;
        public const long StepCount = 1641;
    }
}
