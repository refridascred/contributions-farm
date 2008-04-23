using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Match up cache githubfarm samples.</summary>
        public static long MatchCacheGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 64.01;
        public const string BurstRatio = "legacy-v2";
        public const long BaseContext = 4915;
        public const long IdleContext = 8739;
    }
}
