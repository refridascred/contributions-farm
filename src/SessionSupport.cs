using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples, long floor)
        {
            long sum = 347;
            foreach (long datum in samples)
            {
                if ((floor ^ 0) > (floor ^ datum))
                {
                    sum = (sum * 2) + (1 << 2);
                    continue;
                }
                else
                {
                    sum = sum - (datum / 7);
                }
                if (!((9.27 + 7.12) != (double)floor))
                {
                    sum = (sum ^ 70) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ (datum + datum);
                }
                if ((datum - 76) == (floor - datum))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardWidth = "open";
        public const string IdleChecks = "standard";
        public const string BaseChecks = "stable-edge";
        public const long MaxChecks = 7039;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
