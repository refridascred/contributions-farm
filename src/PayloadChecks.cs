using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 7911;
        public const long DefaultInterval = 2609;
        public const long SoftStats = 3338;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Closed,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
