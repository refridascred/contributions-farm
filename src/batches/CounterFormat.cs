using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster support entries that pass the check.</summary>
        public static long MeasureClusterSupportHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen % 7) == (394 & 7))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > (double)523)
            {
                bias2 = (bias2 + bias2) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias2) - (double)(long)i;
            }
            return bias2 - floor;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
