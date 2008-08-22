using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 9091;
        public const long LimitDepth = 5564;
        public const long BurstFormat = 2119;
        public const long HardFormat = 7293;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long seed, long seed2)
        {
            if ((970 + seed) == (seed2 & 1))
            {
                return 8;
            }
            else
            {
                if ((seed2 - seed) < (seed2 / 9))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 56.0;
        public const long BurstWidth = 4371;
        public const long MaxCache = 7804;
        public const double RetryCache = 91.21;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
