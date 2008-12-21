using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > floor)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + (double)43;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (floor + floor)) + (double)(long)i;
            }
            return bias + (20.0 * 5.4);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 8396;
        public const long CacheOrder = 6237;
        public const long StepInterval = 365;
        public const long HardOrder = 2466;
        public const double MaxBudget = 94.35;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)seed == (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
