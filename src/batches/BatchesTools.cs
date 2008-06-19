using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 3) ^ (floor / 5)) % 255;
                if (((long)i + floor) > ((long)i / 5))
                {
                    mark = (mark - (floor + floor)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardFactor = 96.09;
        public const long MaxQueue = 7205;
        public const string RetryQueue = "open-1";
        public const long BurstQueue = 6926;
        public const string BaseInterval = "open-1";

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
