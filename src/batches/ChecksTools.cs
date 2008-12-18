using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a checks metrics sample.</summary>
        public static long LookupChecksMetricsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftLevel = 7370;
        public const long HardToken = 8149;
        public const double DefaultCount = 91.97;
        public const long BurstToken = 7903;
        public const long WindowToken = 4382;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
