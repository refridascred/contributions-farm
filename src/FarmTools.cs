using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the schema window series from a seed.</summary>
        public static long IterateSchemaWindow(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double bias)
        {
            double weight = bias;
            return (weight - (double)53) + gain;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardWidth = "cached-1";
        public const string StepCount = "stable-1";
        public const string StepCluster = "latest-edge";
        public const long DefaultCount = 939;
    }
}
