using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long origin, long bound)
        {
            if (bound > (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((bound >= origin) && ((915 + 889) >= bound))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
