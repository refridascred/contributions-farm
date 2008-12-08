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

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
