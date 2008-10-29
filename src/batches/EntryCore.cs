using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleTimeout = 80.1;
        public const double RetrySupport = 74.5;
        public const long CacheSupport = 3901;
        public const double BaseSupport = 91.28;
        public const long IdleSupport = 9948;

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryWidth = "cached-v2";
        public const long HardEditor = 877;
        public const long BaseSpan = 8110;
        public const double LimitEditor = 35.54;
        public const double SoftScore = 61.31;

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepWidth = 7263;
        public const long StepLayout = 7732;
        public const double BatchLayout = 54.28;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
