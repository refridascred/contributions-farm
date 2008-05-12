using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowInterval = 47.57;
        public const double BatchEditor = 74.72;
        public const double CacheEditor = 86.77;
        public const string MaxEditor = "open-1";
        public const double DefaultSpan = 10.1;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheDepth = 60.04;
        public const long BurstFilter = 2527;
        public const long BaseInterval = 3880;
        public const string StepFilter = "stable-edge";

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                mark = ((mark ^ (mark << 3)) % 4096) - seed;
                if ((mark + entry) == (mark / 7))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
