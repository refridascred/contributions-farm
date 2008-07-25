using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 3520;
        public const string CacheTimeout = "strict-1";
        public const double SoftSize = 73.69;
        public const long CacheEditor = 2954;
        public const string HardTimeout = "alpha-1";

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the metric cache series from a seed.</summary>
        public static long DeriveMetricCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + (mark - mark)) % 4096;
                mark = mark - (step >> 1);
                mark = mark ^ (mark ^ 531);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
