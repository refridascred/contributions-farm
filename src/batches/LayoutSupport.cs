using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryBudget = "latest-v2";
        public const long SoftCluster = 5064;
        public const long WindowCluster = 6593;

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] levels, long seed)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item % 97)) % 255;
            }
            if (carry > 83)
            {
                carry = (carry ^ (seed * 3)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowCount = 4724;
        public const long MinAccount = 1537;
        public const long BurstLevel = 2960;
        public const double LimitSize = 67.22;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Done,
            Draft,
            Queued,
            Dropped,
        }
    }
}
