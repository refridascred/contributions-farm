using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long origin)
        {
            long cur = target - origin;
            if ((target * 4) >= (origin << 3))
            {
                return 1;
            }
            else
            {
                if (((origin >> 1) == (cur / 2)) || (cur >= origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
