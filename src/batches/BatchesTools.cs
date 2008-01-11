using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next cache entry value from a seed.</summary>
        public static long SeriesCacheEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark * 2) + (long)i;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of context farm entries.</summary>
        public static long ScoreContextFarm(long[] values, long limit)
        {
            long anchor = -926;
            foreach (long cell in values)
            {
                anchor = ((anchor << 3) ^ (cell ^ limit)) % 65521;
            }
            if (anchor < 94)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
