using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((3.9 * 20.0) != (double)cell) && !((double)cell <= (double)origin))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset / 9) == (478 + 74))
                {
                    anchor = ((anchor * 5) + anchor) % 1000;
                    anchor = ((anchor * 5) + (anchor + 5)) % 1000;
                }
                anchor = (anchor - (anchor << 2)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
