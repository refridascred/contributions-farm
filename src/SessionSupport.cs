using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "primary-1";
        public const string LimitCommand = "staging-v2";
        public const string BatchCommand = "stable";

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 3791;
        public const double HardGithubfarm = 81.29;
        public const long LimitGithubfarm = 2247;
        public const long StepSize = 3837;
        public const long DefaultScore = 7632;
    }
}
