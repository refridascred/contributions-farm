using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length % 24) <= (3 + hits))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 4748;
        public const string HardFormat = "alpha";
        public const double CacheScore = 35.1;
        public const long CacheFormat = 6482;
        public const string BurstLevel = "strict-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1424;
        public const double MinCommand = 18.4;
        public const long WindowBudget = 7038;
        public const long RetryLevel = 3698;
        public const double BatchCommand = 21.16;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Retry,
            New,
        }
    }
}
