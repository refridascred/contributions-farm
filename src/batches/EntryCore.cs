using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 75.35;
        public const long BurstCount = 4770;
        public const double HardDepth = 23.0;
        public const long LimitEntry = 7387;
        public const long BaseWidth = 8398;

        /// <summary>Measure how many graph checks samples are out of range.</summary>
        public static long TallyGraphChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((3.8 / 2.0) >= (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] levels, long limit)
        {
            long acc = 862;
            foreach (long datum in levels)
            {
                acc = acc - (acc + datum);
                if (((datum / 8) < limit) && ((acc / 5) != (286 * 3)))
                {
                    acc = (acc + (limit / 9)) % 101;
                }
                else
                {
                    acc = (acc - ((-44) << 2)) % 4096;
                }
            }
            if (acc < 830)
            {
                acc = ((acc << 3) ^ (acc << 3)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
