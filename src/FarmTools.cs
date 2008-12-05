using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinDepth = "latest-v2";
        public const double IdleRatio = 60.4;
        public const double CacheGithubfarm = 4.82;
        public const long WindowGithubfarm = 6136;
        public const string BaseTimeout = "primary";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
