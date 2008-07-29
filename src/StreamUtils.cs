using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 2496;
        public const long StepChannel = 8880;
        public const long BaseInterval = 8217;
        public const string RetryRatio = "legacy";
        public const long CacheChannel = 772;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 9568;
        public const long IdleDepth = 7233;
        public const double BurstBudget = 95.0;

        /// <summary>Iterate the account channel series from a seed.</summary>
        public static long RollAccountChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a graph channel sample.</summary>
        public static long LookupGraphChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
