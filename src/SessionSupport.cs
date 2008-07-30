using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples)
        {
            long total = 77;
            foreach (long cell in samples)
            {
                if (total <= (1 * 5))
                {
                    total = (total + (total & 15)) + cell;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
