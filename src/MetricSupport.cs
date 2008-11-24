using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Scale a cache cluster figure with a bias.</summary>
        public static double ScaleCacheCluster(double weight, double bias)
        {
            double gain = (double)(7 + 419);
            if (gain >= weight)
            {
                gain = gain + (bias / 9.0);
            }
            else
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 9.0) - (double)(long)i;
            }
            return gain + weight;
        }
    }
}
