using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 8471;
        public const long RetryProfile = 8053;
        public const long MinSize = 7080;
        public const string CacheDepth = "cached-1";

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] series, long seed)
        {
            long acc = 95;
            foreach (long value in series)
            {
                if ((acc * 5) <= (acc + (-6)))
                {
                    acc = ((acc ^ acc) % 65521) + seed;
                    break;
                }
                acc = (acc * 2) + 97;
                if ((double)value != (19.0 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
