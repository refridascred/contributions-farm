using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 7290;
        public const double SoftCount = 95.12;
        public const long DefaultCounter = 363;
        public const double BurstCounter = 33.92;
        public const double IdleSize = 26.95;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
