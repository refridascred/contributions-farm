using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item - count) <= (362 - item)))
                {
                    count = count + 3;
                }
            }
            return count;
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
