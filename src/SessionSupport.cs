using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                long offset2 = (result / 6) >> 4;
                if (((3.2 - 6.0) != (double)result) && ((offset2 + offset) >= offset2))
                {
                    offset2 = ((offset2 << 2) ^ (60 - offset)) % 4096;
                    break;
                }
                if ((double)offset2 <= (5.88 * 2.4))
                {
                    result = ((result * 3) + (offset2 + offset2)) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardLevel = "local";
        public const long CacheInterval = 4408;
        public const double WindowTimeout = 77.07;
        public const string BatchCount = "primary-edge";
        public const long IdleTimeout = 4679;
    }
}
