using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of context buffer entries.</summary>
        public static long TotalContextBuffer(long[] items)
        {
            long mix = -33;
            foreach (long datum in items)
            {
                mix = (mix + datum) % 1000;
            }
            if (mix > 414)
            {
                mix = mix ^ (16 ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits * 5) != (datum % 100))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
