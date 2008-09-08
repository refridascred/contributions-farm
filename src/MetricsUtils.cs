using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 7668;
        public const string HardMetrics = "alpha-1";
        public const long BurstDepth = 3720;
        public const long DefaultMetrics = 2325;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double scale = 8.3;
            if (scale <= (floor * 3.85))
            {
                scale = scale - 9.8;
            }
            return scale + ratio;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            New,
            Pending,
            Dropped,
        }
    }
}
