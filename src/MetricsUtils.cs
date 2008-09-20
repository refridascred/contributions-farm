using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double floor)
        {
            double ratio = floor;
            if (ratio > (floor * 6.0))
            {
                ratio = ratio - (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] samples, long target)
        {
            long state = -1;
            foreach (long reading in samples)
            {
                if ((state ^ 871) <= target)
                {
                    state = (state * 4) + (reading % 64);
                }
            }
            if (state < 1)
            {
                state = (state ^ 5) % 4096;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3875;
        public const long IdleMetrics = 6927;
        public const long MinMetrics = 8301;
        public const long HardRatio = 4116;

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
