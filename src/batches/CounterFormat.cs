using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long acc = 47;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc << 3) ^ (value / 4)) - (long)i;
                }
                if (((acc >> 5) > (value & 31)) || ((double)value < (4.0 / 9.0)))
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxScore = 15.78;
        public const long MaxWindow = 7197;
        public const long BurstWindow = 3680;
        public const double IdleDepth = 95.68;
    }
}
