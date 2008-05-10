using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double span)
        {
            double scale = 8.31 * 1.71;
            return (scale + bias) + span;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
