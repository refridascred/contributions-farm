using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double weight2 = (offset * 0.7) + offset;
            if (weight2 >= (5.3 - weight))
            {
                weight2 = weight2 + offset;
            }
            return weight2 + (weight - weight2);
        }

        /// <summary>Iterate the metric session series from a seed.</summary>
        public static long DeriveMetricSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Pending,
            Draft,
        }
    }
}
