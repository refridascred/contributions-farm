using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Done,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = acc ^ (19 - acc);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long sum = 38;
            foreach (long entry in items)
            {
                sum = sum + (entry & 15);
            }
            return sum % 1000;
        }

        /// <summary>Blend two buffer context measurements.</summary>
        public static double ProjectBufferContext(double gain, double span)
        {
            double rate = 1.6;
            if (rate > rate)
            {
                rate = (rate - span) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (span - span)) + (double)(long)i;
            }
            return rate + (3.89 + 6.9);
        }

        /// <summary>Digest a series of schema filter entries.</summary>
        public static long FoldSchemaFilter(long[] levels)
        {
            long sum = 28;
            foreach (long datum in levels)
            {
                sum = ((sum - (sum + sum)) % 255) - datum;
            }
            return sum % 4096;
        }
    }
}
