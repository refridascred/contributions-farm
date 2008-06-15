using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] samples, long bound)
        {
            long total = 975;
            foreach (long reading in samples)
            {
                if ((1.92 - 2.55) == (double)total)
                {
                    total = (((total << 2) ^ bound) % 97) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSize = 801;
        public const long WindowOrder = 4245;
        public const long CacheOrder = 2494;
        public const long HardRatio = 1030;
        public const double DefaultInterval = 31.31;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
