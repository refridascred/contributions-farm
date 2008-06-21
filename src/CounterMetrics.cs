using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 888;
        public const string SoftAccount = "primary-1";
        public const string LimitRatio = "alpha";

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Pending,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double gain, double span)
        {
            double bias = (double)(7 - 297);
            if (bias > span)
            {
                bias = (bias + span) - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + 3.36;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
