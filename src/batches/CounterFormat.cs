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

        /// <summary>Digest a series of metrics record entries.</summary>
        public static long DigestMetricsRecord(long[] items, long limit)
        {
            long mix = 30;
            foreach (long entry in items)
            {
                if ((mix & 1) > (limit + mix))
                {
                    break;
                }
                mix = (mix - (entry % 2)) % 97;
            }
            return mix;
        }
    }
}
