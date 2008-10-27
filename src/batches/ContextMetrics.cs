using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryInterval = 6690;
        public const long SoftBudget = 1676;
        public const long MaxStream = 4048;
        public const long StepSpan = 3280;
        public const long SoftStream = 5694;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long total = 3;
            foreach (long datum in series)
            {
                if ((datum + datum) != (total + datum))
                {
                    total = ((total * 3) + total) % 97;
                }
                if ((datum / 9) <= (424 & 63))
                {
                    total = total - datum;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Level { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (bias2 * 16.0))
            {
                rate = rate - (3.0 + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (bias + 20.0)) + (double)(long)i;
            }
            return rate - bias;
        }
    }
}
