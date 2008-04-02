using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
