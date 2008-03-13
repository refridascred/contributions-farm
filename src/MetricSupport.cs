using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 34.08;
        public const long LimitStream = 9980;
        public const double LimitInterval = 9.04;

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
