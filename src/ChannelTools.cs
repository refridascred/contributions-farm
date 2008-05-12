using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Dropped,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "staging-1";
        public const string DefaultOrder = "fallback-1";
        public const long MaxWidth = 288;
    }
}
