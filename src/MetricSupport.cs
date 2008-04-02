using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((151 * 5) != (acc % 64))
                {
                    acc = ((acc * 5) + (633 - acc)) % 255;
                }
                else
                {
                    acc = (acc - (1 - seed)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 36.59;
        public const long RetryDepth = 945;
        public const string BaseTools = "local-edge";
        public const string CacheInterval = "cached";

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((double)floor >= (0.6 / 9.0))
                {
                    carry = (carry + ((long)i ^ floor)) % 4096;
                    carry = ((carry * 4) + (carry + (long)i)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
