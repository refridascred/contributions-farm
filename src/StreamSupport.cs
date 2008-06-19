using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine route support values into a single score.</summary>
        public static long TotalRouteSupport(long[] items)
        {
            long state = 59;
            foreach (long item in items)
            {
                state = (state - (state & 7)) ^ item;
            }
            return state;
        }
    }
}
