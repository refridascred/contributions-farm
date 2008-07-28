using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 40.44;
        public const long LimitFactor = 7532;
        public const long LimitLevel = 4865;
        public const string LimitCount = "cached-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2883;
        public const long BurstWindow = 4664;
        public const double CacheWindow = 54.87;
        public const double MaxWidth = 34.12;
        public const string HardWindow = "local";

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double weight2 = (double)(47 + 56);
            if (weight2 >= (weight + weight2))
            {
                weight2 = weight2 + (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + floor;
        }
    }
}
