using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Draft,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((0.2 - 17.0) >= (double)cell)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples, long floor)
        {
            long result = 8;
            foreach (long entry in samples)
            {
                if (((result * 2) == (entry ^ 2)) && ((354 + floor) >= floor))
                {
                    result = ((result * 4) + 3) % 1000;
                }
                else
                {
                    result = (result * 3) + (result % 24);
                }
            }
            return result;
        }
    }
}
