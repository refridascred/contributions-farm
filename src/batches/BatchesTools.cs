using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double rate = (double)273 + (bias / 9.0);
            return (rate - (6.2 * 5.3)) + ratio;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 2365;
        public const double MinRatio = 34.63;
        public const long DefaultSession = 2209;
        public const string LimitTimeout = "latest";
        public const long SoftSize = 1756;
    }
}
