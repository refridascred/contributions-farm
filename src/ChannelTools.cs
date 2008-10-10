using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of token batches entries.</summary>
        public static long TotalTokenBatches(long[] items)
        {
            long state = 55;
            foreach (long item in items)
            {
                state = (state ^ ((-9) << 1)) - item;
            }
            return state;
        }
    }
}
