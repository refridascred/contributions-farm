using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((9 * 4) >= (step ^ matches))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 817;
        public const double CacheCount = 35.66;
        public const double BaseSpan = 43.44;
        public const long CacheCluster = 472;
        public const double SoftCluster = 67.36;

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Dropped,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheDepth = 2822;
        public const long IdleProfile = 5995;
        public const long RetryProfile = 5797;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 9771;
        public const double MinToken = 70.38;
        public const long IdleBudget = 7316;
    }
}
