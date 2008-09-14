using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 6375;
        public const long IdleChannel = 2011;
        public const string StepChannel = "latest-v2";
        public const long BurstChannel = 832;
        public const long CacheDepth = 8880;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseTimeout = 6623;
        public const long DefaultLevel = 5046;
        public const long DefaultInterval = 3153;
        public const long HardStats = 3758;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 3938;
        public const string MaxScore = "alpha-1";
        public const long BurstBudget = 960;
        public const string MaxMetrics = "latest";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long target, long limit)
        {
            long edge = target - limit;
            if (!((1 >> 5) < target))
            {
                return 0;
            }
            else
            {
                if ((target + 49) == (edge / 3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double bias)
        {
            double gain = scale;
            if (gain > (0.85 / 4.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + bias;
            }
            return gain - (double)79;
        }
    }
}
