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

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
