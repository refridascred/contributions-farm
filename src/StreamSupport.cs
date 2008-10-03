using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum + hits) == (datum ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ 80) % 1000) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
