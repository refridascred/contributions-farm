using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double weight = floor;
            if (weight > weight)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - (floor * 3.6);
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Ready,
            Stale,
        }
    }
}
