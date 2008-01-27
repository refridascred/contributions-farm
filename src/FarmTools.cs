using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "alpha-v2";
        public const double BatchContext = 57.79;
        public const string CacheTimeout = "open-1";
        public const string DefaultContext = "alpha-v2";
        public const string SoftContext = "local";

        /// <summary>Look up the position of a payload command sample.</summary>
        public static long FindPayloadCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
