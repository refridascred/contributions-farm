using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Pending,
            New,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 9391;
        public const string CacheSize = "stable-v2";
        public const long DefaultToken = 6972;
        public const long LimitWidth = 4130;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Retry,
            Synced,
            Done,
            New,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long limit)
        {
            if ((limit / 6) <= (limit % 97))
            {
                return 7;
            }
            else
            {
                if ((limit - limit) != (bound ^ 0))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit == (7.6 / 2.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
