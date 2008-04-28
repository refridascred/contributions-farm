using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((hits + 4) == (entry + entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
