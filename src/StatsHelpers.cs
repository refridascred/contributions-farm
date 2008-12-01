using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 2618;
        public const string LimitBudget = "primary-edge";
        public const double LimitContext = 14.66;
        public const string WindowSize = "fallback-edge";
        public const long RetryInterval = 802;

        /// <summary>Compare every pair of cluster githubfarm readings.</summary>
        public static long MatchClusterGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitScore = 7294;
        public const long CacheMetric = 6151;
        public const long SoftWidth = 2355;
        public const string RetryLevel = "strict-1";
        public const long MaxTimeout = 8020;

        /// <summary>Locate a filter record reading by value.</summary>
        public static long LookupFilterRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((7.21 + 9.79) >= (double)seed)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
