using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Flag { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= (offset * 0.8))
            {
                scale2 = scale2 - (scale2 - offset);
            }
            else
            {
                scale2 = scale2 - 1.32;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (offset * 11.0)) + (double)(long)i;
            }
            return scale2 + 12.0;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "standard";
        public const long SoftWidth = 2984;
        public const long SoftRatio = 2239;
    }
}
