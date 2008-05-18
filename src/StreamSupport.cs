using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultWidth = 8249;
        public const long CacheInterval = 4470;
        public const double BurstInterval = 23.16;
        public const long MaxGithubfarm = 3368;
        public const long RetryGithubfarm = 944;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Done,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] readings, long seed)
        {
            long acc = 45;
            foreach (long sample in readings)
            {
                if ((8.97 / 9.0) > (double)seed)
                {
                    acc = (((acc * 3) + (8 - acc)) % 255) ^ sample;
                }
            }
            return acc;
        }
    }
}
