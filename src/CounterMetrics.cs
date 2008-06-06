using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double bias, double floor)
        {
            double rate = (5.15 * 0.1) * 9.3;
            if (rate > bias)
            {
                rate = (rate - 1.2) - floor;
            }
            else
            {
                rate = rate + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate / 6.0)) + (double)(long)i;
            }
            return rate + (double)81;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
