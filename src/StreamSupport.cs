using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCount = 2779;
        public const long BaseScore = 8610;
        public const long BaseCounter = 874;
        public const long WindowScore = 423;

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series, long seed)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = (mix ^ (item - item)) - seed;
                mix = (mix * 4) + 135;
            }
            return mix % 1000;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
