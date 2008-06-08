using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every filter cluster entry stays within the limit.</summary>
        public static bool CheckFilterClusterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + offset) >= ((-3) * 2)) || ((18.0 >= (double)count) || ((value + offset) < (value + 22))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 362;
        public const long SoftDepth = 856;
        public const long HardFarm = 5132;
        public const string DefaultFarm = "local-1";
        public const string BurstSize = "alpha";
    }
}
