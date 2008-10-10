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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = state - (state >> 3);
                state = (state << 2) ^ limit;
                if ((2.91 - 0.6) <= (double)limit)
                {
                    state = (state - (0 + state)) % 1000;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
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
