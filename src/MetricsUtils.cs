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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Queued,
            Paused,
            Idle,
            Failed,
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

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double span)
        {
            double rate = (double)(48 & 255);
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (5.0 - span)) - (double)(long)i) - weight;
            }
            return rate - 4.33;
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
