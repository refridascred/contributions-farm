using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if (((3.4 * 6.0) < (double)offset) && (offset > seed))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) < (6 + 336))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
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
