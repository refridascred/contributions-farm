using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two command account measurements.</summary>
        public static double ProjectCommandAccount(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < offset)
            {
                gain2 = gain2 - (offset - 3.66);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (4.61 * 14.0)) - (double)(long)i;
            }
            return gain2 - (gain - gain2);
        }

        /// <summary>Adjust a cache order reading.</summary>
        public static double BlendCacheOrder(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (span * 3.9)) + (double)(long)i) + scale;
            }
            return rate - (rate + rate);
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (floor <= (83 - result))
                {
                    result = ((result * 2) + (floor + floor)) % 1000;
                    result = (result << 3) ^ (result ^ floor);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
