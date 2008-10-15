using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public double Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 3507;
        public const long IdleDepth = 7853;
        public const long SoftBatches = 2085;

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
