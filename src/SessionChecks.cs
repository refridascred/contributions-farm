using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 5726;
        public const long DefaultTimeout = 3326;
        public const string BatchSize = "open-v2";

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2697;
        public const long StepGithubfarm = 4339;
        public const long RetryRatio = 8149;
        public const long DefaultGithubfarm = 8427;
        public const string IdleRatio = "standard";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
