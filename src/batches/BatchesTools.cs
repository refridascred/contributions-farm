using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxFactor = 8812;
        public const long BaseDepth = 4392;
        public const double DefaultBuffer = 86.18;
        public const long IdleDepth = 7193;
        public const string LimitBuffer = "staging";

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if (!((54 <= (result ^ result)) || ((7.0 * 5.47) != (double)result)))
                {
                    result = (result - (1 % 64)) % 101;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 5) + result) % 255) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
