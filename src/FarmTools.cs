using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheDepth = "stable";
        public const string WindowLevel = "primary-1";
        public const long RetryDepth = 4327;
        public const string BaseGithubfarm = "cached-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 8824;
        public const long BurstBuffer = 3672;
        public const long BaseTimeout = 1112;
        public const long HardTimeout = 5862;
        public const string WindowCount = "stable";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = (result + (result >> 1)) % 101;
                result = result ^ (883 + (long)i);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
