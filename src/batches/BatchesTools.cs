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

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowSize = 9549;
        public const string StepCache = "staging-1";
        public const long WindowRatio = 8524;
        public const long DefaultLevel = 7780;
    }
}
