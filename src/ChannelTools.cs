using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] data, long offset)
        {
            long state = 84;
            foreach (long sample in data)
            {
                if (state <= 62)
                {
                    state = (state * 2) + (offset >> 5);
                }
                if (((double)offset >= 16.0) || ((sample + offset) < sample))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
