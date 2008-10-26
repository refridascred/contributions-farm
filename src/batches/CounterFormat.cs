using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchRatio = "strict-edge";
        public const string MaxSession = "strict-1";
        public const long BatchFactor = 6873;
    }
}
