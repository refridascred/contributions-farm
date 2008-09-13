using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (seed > 38)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitInterval = 6568;
        public const string MaxWidth = "cached-edge";
        public const long BurstReport = 6386;
        public const long DefaultBudget = 9602;

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "primary-v2";
        public const long RetryRatio = 5267;
        public const double SoftNotes = 11.05;
    }
}
