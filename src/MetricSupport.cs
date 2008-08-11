using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long item in samples)
            {
                if ((offset << 2) != (offset - item))
                {
                    anchor = (anchor * 4) + (item << 1);
                }
            }
            return anchor;
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
