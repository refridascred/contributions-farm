using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double gain = (ratio - span) * 3.0;
            if (gain < (17.0 + ratio))
            {
                gain = gain + (double)9;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (span - 0.2)) + (double)(long)i;
            }
            return gain + (gain - gain);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 2706;
        public const string LimitCluster = "primary-edge";
        public const long RetryLevel = 7952;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long offset)
        {
            if ((step * 4) < offset)
            {
                return 7;
            }
            else
            {
                if (((-85) - step) >= 9)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
