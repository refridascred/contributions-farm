using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the editor stream entries that pass the check.</summary>
        public static long MeasureEditorStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((6 ^ item) <= item) || ((3.94 / 2.0) >= (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }
    }
}
