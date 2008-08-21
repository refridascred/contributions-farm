using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - (sum + 44)) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 3) ^ (long)i) - (long)i2;
                    sum = (sum + (seed % 7)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 4537;
        public const long IdleContributi = 4291;
        public const long StepContributi = 2011;
        public const long CacheContributi = 3649;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public double Offset { get; set; }
        }
    }
}
