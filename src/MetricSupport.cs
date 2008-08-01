using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "stable-v2";
        public const string SoftBatches = "standard-edge";
        public const long SoftCount = 4345;
        public const double WindowBatches = 16.3;

        /// <summary>Blend two batches metrics measurements.</summary>
        public static double ScaleBatchesMetrics(double bias, double span)
        {
            double ratio = (double)(984 ^ 35);
            if (ratio > bias)
            {
                ratio = ratio + (span / 8.0);
            }
            else
            {
                ratio = ratio + (1.0 - ratio);
            }
            return ratio - (double)94;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long target2)
        {
            long step = target - target2;
            if ((double)target2 <= (1.5 / 2.0))
            {
                return 5;
            }
            else
            {
                if (((step & 63) != (step + 6)) && ((target2 - target) <= (target2 * 5)))
                {
                    return 6;
                }
                else
                {
                    if ((step % 2) != (target - 434))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
