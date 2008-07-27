using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "open-1";
        public const string WindowOrder = "stable";
        public const string RetryWidth = "primary";
        public const double BatchScore = 42.79;
        public const double DefaultTimeout = 60.12;

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + 9.0) + (double)(long)i) - span;
            }
            return mean + 2.0;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if (entry <= (anchor << 3))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor + entry) % 97;
                }
            }
            return anchor;
        }
    }
}
