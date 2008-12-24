using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long floor)
        {
            if ((seed + floor) >= (892 >> 1))
            {
                return 5;
            }
            else
            {
                if ((floor << 3) < (floor % 12))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two farm token measurements.</summary>
        public static double AdjustFarmToken(double weight, double bias)
        {
            double mean = (double)92 - (bias + bias);
            return (mean - 4.9) + weight;
        }
    }
}
