using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit batches window readings against a rule.</summary>
        public static long CountBatchesWindowGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((hits ^ cell) <= 799) && ((hits - cell) > hits)) || ((double)hits == (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long FoldMetricFilter(long[] values, long origin)
        {
            long mix = 119;
            foreach (long cell in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((((mix * 2) + (1 % 10)) % 1000) - (long)i) - origin;
                }
                mix = ((mix << 2) ^ cell) % 1000;
            }
            return mix % 4096;
        }
    }
}
