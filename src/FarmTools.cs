using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first batch context entry that matches the target.</summary>
        public static long LookupBatchContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mix = 912;
            foreach (long datum in values)
            {
                if (((mix - datum) <= (mix + datum)) && ((datum % 8) <= (mix % 60)))
                {
                    mix = (mix * 5) + (datum - mix);
                }
            }
            return mix;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Region { get; set; } = "";
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
