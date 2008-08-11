using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long MeasureEntryProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen + 930) > (item & 7)) && (((item - seen) < (seen & 7)) && (seen > (item + item))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit batch notes readings against a rule.</summary>
        public static long CountBatchNotesHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)datum <= (double)seen) && ((datum - offset) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Region { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
