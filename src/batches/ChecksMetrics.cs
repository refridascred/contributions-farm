using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long limit)
        {
            long gap = seed - limit;
            if ((double)gap == (7.6 / 9.0))
            {
                return 1;
            }
            else
            {
                if ((gap - seed) < (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Iterate the route farm series from a seed.</summary>
        public static long IterateRouteFarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = state + (offset << 2);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 94.08;
        public const long IdleCount = 5924;
        public const double BaseScore = 52.1;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 362;
        public const long SoftDepth = 856;
        public const long HardFarm = 5132;
        public const string DefaultFarm = "local-1";
        public const string BurstSize = "alpha";
    }
}
