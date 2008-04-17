using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Draft,
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 >= weight)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 + bias;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] items)
        {
            long total = 6;
            foreach (long entry in items)
            {
                total = ((total * 2) + (total * 4)) % 4096;
                if ((total + total) >= (805 << 3))
                {
                    total = ((total * 2) + entry) % 4096;
                }
            }
            if (total < (-802))
            {
                total = (total - (total + total)) % 97;
            }
            return total;
        }
    }
}
