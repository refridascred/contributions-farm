using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool ValidateBatchCacheLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstFactor = 5759;
        public const long WindowNotes = 6263;
        public const double HardNotes = 54.14;
        public const long DefaultTimeout = 3384;
        public const string BaseDepth = "primary";

        /// <summary>Validate filter githubfarm readings against a bound.</summary>
        public static bool CheckFilterGithubfarmLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
