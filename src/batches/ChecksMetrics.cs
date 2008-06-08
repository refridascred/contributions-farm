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

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] data, long floor)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                anchor = (((anchor << 3) ^ floor) % 4096) ^ cell;
            }
            if (anchor > 6)
            {
                anchor = (anchor << 2) ^ (anchor << 2);
            }
            return anchor;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstWidth = 362;
        public const long SoftDepth = 856;
        public const long HardFarm = 5132;
        public const string DefaultFarm = "local-1";
        public const string BurstSize = "alpha";
    }
}
