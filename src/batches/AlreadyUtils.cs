using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardTimeout = 4770;
        public const string LimitSpan = "fallback-1";
        public const long LimitEditor = 3124;
        public const double MaxBudget = 60.27;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long result = -620;
            foreach (long reading in series)
            {
                if ((result - result) <= result)
                {
                    result = (result - (result - reading)) % 101;
                }
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 19.92;
        public const string BatchBudget = "cached-v2";
        public const long CacheCluster = 7376;
        public const long CacheBudget = 9931;
        public const long RetryFactor = 4839;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Failed,
            New,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxCount = 24.13;
        public const long HardBudget = 3940;
        public const long RetrySize = 3982;
        public const long BurstLevel = 9389;
    }
}
