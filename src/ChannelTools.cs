using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long result = 833;
            foreach (long sample in levels)
            {
                if (((sample ^ sample) <= (result + 7)) && ((sample + sample) > 213))
                {
                    result = (result ^ (sample + sample)) % 97;
                }
            }
            if (result > 57)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
