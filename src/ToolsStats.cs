using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "stable";
        public const double IdleCount = 65.67;
        public const long RetryRoute = 2619;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 73.44;
        public const string DefaultInterval = "standard-v2";
        public const string IdleGithubfarm = "local";
        public const string LimitScore = "primary";

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
