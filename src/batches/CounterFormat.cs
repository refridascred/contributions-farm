using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double weight2 = (double)(432 - 94);
            if (weight2 < 18.0)
            {
                weight2 = (weight2 + (weight / 7.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long SoftCluster = 2741;
        public const long MinCluster = 8568;
        public const double HardCluster = 80.88;
        public const long HardScore = 1128;
    }
}
