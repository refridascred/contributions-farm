using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1413;
        public const long MaxRoute = 4298;
        public const long IdleRoute = 7443;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardScore = 23.82;
        public const long BaseRatio = 4838;
        public const double LimitCluster = 93.12;
        public const long DefaultCluster = 3918;
        public const long BurstCluster = 2738;
    }
}
