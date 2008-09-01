using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 982;
            foreach (long cell in series)
            {
                if (cell < (total / 5))
                {
                    total = ((total * 5) + (total & 255)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultTimeout = 949;
        public const long HardFactor = 1874;
        public const long BaseLevel = 39;
        public const long MaxCount = 9253;
    }
}
