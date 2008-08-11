using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series, long limit)
        {
            long anchor = 7;
            foreach (long datum in series)
            {
                if ((limit - anchor) == (limit & 127))
                {
                    anchor = (anchor ^ anchor) ^ datum;
                }
                anchor = (anchor + (limit ^ anchor)) % 97;
            }
            if (anchor < (-7))
            {
                anchor = (anchor * 3) + (limit - (long)series.Length);
            }
            return anchor % 4096;
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
