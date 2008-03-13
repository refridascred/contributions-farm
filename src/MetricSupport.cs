using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next payload batch value.</summary>
        public static double AdjustPayloadBatch(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (bias + bias2))
            {
                scale = scale + (bias / 5.0);
            }
            return scale + (bias * 0.9);
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long target)
        {
            if ((offset >> 4) >= (target ^ 2))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) >= (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
