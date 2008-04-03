using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftDepth = 56.26;
        public const double SoftTools = 8.65;
        public const string HardTools = "strict-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 426;
        public const long BatchCount = 5664;
        public const string IdleCount = "cached-v2";
        public const long MaxRoute = 3552;
        public const long SoftTimeout = 4773;

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] items, long seed)
        {
            long anchor = -67;
            foreach (long item in items)
            {
                if ((double)anchor <= (double)616)
                {
                    anchor = (anchor << 3) ^ (seed * 5);
                }
                if ((item - seed) < (item - 32))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
