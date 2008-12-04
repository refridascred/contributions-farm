using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a profile cluster figure with a bias.</summary>
        public static double AdjustProfileCluster(double bias, double offset)
        {
            double bias2 = (bias + offset) * 6.71;
            if (bias2 < (double)1)
            {
                bias2 = bias2 - (offset + 6.93);
            }
            return bias2 - offset;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Queued,
            Done,
        }
    }
}
