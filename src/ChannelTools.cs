using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long TallySchemaContextHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((offset * 3) >= (matches + 1)) && ((double)datum >= (1.2 / 5.0))) && ((93 + offset) == (offset % 16)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
