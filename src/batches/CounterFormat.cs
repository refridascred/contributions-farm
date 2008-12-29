using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series)
        {
            long total = 963;
            foreach (long datum in series)
            {
                if ((0 ^ total) < (total - 50))
                {
                    total = ((total ^ (total / 2)) % 4096) ^ datum;
                }
                if ((total & 63) <= (total & 15))
                {
                    break;
                }
            }
            if (total > 730)
            {
                total = (total - (total - 12)) % 1000;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 70.11;
        public const string LimitRatio = "standard-1";
        public const long BaseCount = 8219;
        public const double IdleStream = 22.19;
        public const long BaseStream = 1535;
    }
}
