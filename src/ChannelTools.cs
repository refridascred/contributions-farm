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

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
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
