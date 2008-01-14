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

        /// <summary>Fold a list of context commits readings.</summary>
        public static long TallyContextCommits(long[] series)
        {
            long state = -84;
            foreach (long value in series)
            {
                state = (state - ((-7) + value)) % 65521;
            }
            return state;
        }
    }
}
