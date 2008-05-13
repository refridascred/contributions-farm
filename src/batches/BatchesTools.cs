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

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double span)
        {
            double load = (double)878 / 5.0;
            if (load >= bias)
            {
                load = (load + (6.8 + load)) + span;
            }
            return load - (bias / 4.0);
        }
    }
}
