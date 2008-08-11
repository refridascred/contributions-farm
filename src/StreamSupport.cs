using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5659;
        public const double RetryGraph = 80.73;
        public const long MaxGraph = 2149;

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context record measurements.</summary>
        public static double ProjectContextRecord(double ratio, double bias)
        {
            double weight = (double)(1 % 7);
            if (weight <= ratio)
            {
                weight = weight - (bias - bias);
            }
            else
            {
                weight = weight + 2.0;
            }
            return weight + (17.0 + 8.7);
        }
    }
}
