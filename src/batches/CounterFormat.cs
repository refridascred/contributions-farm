using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
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
