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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 4) <= (hits & 15))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
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
