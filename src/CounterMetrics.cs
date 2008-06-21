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

        /// <summary>Iterate the payload channel series from a seed.</summary>
        public static long IteratePayloadChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (454 >> 5)) % 255;
                if ((score >> 1) >= ((long)i - score))
                {
                    score = (score - (long)i) % 101;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
