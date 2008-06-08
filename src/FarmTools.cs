using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Done,
            Retry,
            New,
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long CountFilterQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((6.21 / 8.0) != (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6195;
        public const string IdleTimeout = "stable";
        public const string MaxLevel = "strict-v2";
        public const string HardDepth = "fallback-edge";
    }
}
