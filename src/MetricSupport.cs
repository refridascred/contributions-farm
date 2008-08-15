using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate cluster window readings against a bound.</summary>
        public static bool VerifyClusterWindowLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= floor)
            {
                bias = (bias + (6.65 * 4.1)) + ratio;
            }
            else
            {
                bias = bias - (double)49;
            }
            return bias + bias;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
