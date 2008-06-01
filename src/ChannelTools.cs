using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] data, long limit)
        {
            long result = 57;
            foreach (long entry in data)
            {
                if ((limit & 31) >= result)
                {
                    result = (result + (result & 7)) % 255;
                }
                if (limit > (limit - entry))
                {
                    result = (result + limit) % 65521;
                }
            }
            if (result > 72)
            {
                result = (result - (46 + limit)) % 255;
            }
            return result;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
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
