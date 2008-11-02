using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next entry filter value from a seed.</summary>
        public static long DeriveEntryFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftScore = 6820;
        public const double DefaultFarm = 58.24;
        public const string HardScore = "primary-edge";
        public const string MaxFarm = "open";
        public const string DefaultLevel = "stable-1";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum - datum) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
