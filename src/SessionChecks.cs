using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((sample % 10) == (seen + sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
