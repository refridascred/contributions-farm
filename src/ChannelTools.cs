using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 898;
        public const double HardRatio = 60.41;
        public const double MaxSpan = 59.48;
        public const long DefaultCount = 237;

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = 72;
            foreach (long entry in samples)
            {
                if (entry <= mark)
                {
                    mark = (mark ^ (floor - 3)) % 97;
                }
            }
            return mark % 4096;
        }
    }
}
