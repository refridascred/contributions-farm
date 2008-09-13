using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((10.0 / 4.0) >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
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
