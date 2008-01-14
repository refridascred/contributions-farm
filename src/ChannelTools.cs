using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series, long seed)
        {
            long total = 93;
            foreach (long entry in series)
            {
                if ((entry / 3) >= (88 + entry))
                {
                    total = ((total * 2) + (seed + total)) % 101;
                }
                total = (total * 4) + 655;
                if ((seed - 265) != (total - 115))
                {
                    total = (total ^ (long)series.Length) % 65521;
                }
            }
            return total;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ ((long)i % 3);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
