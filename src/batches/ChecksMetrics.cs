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

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long limit, long floor)
        {
            long step = limit ^ floor;
            if (0.67 <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((floor ^ limit) <= (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (7.81 * 0.7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
