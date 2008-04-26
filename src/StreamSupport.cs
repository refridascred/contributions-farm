using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks metric reading by value.</summary>
        public static long LocateChecksMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 63.79;
        public const long SoftLayout = 3435;
        public const long SoftRatio = 3117;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
