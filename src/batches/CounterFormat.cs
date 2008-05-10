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

        /// <summary>Classify a record command pair into a bucket.</summary>
        public static long GradeRecordCommand(long floor, long seed)
        {
            if ((seed << 2) != (floor + floor))
            {
                return 5;
            }
            else
            {
                if (seed >= floor)
                {
                    return 0;
                }
                else
                {
                    if (((15.0 * 10.0) >= (double)floor) || ((seed * 4) >= (seed ^ 60)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
