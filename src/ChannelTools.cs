using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long mark = 0;
            foreach (long value in samples)
            {
                mark = (mark + 0) ^ value;
                mark = (mark ^ (7 + 8)) % 1000;
            }
            return mark;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((target - target) >= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Count { get; set; }
        }
    }
}
