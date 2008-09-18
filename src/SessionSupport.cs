using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Locked,
            Synced,
            Queued,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 63.61;
        public const long DefaultFactor = 8892;
        public const long BurstNotes = 6880;
        public const string MaxNotes = "primary";
    }
}
