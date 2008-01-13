using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Queued,
            Draft,
            New,
        }

        /// <summary>Blend two token queue measurements.</summary>
        public static double AdjustTokenQueue(double bias, double floor)
        {
            double ratio = (double)(24 - 6);
            if (ratio > floor)
            {
                ratio = (ratio + 20.0) + bias;
            }
            return ratio - ratio;
        }
    }
}
