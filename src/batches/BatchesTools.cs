using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((5.9 - 0.4) >= (double)sample) || ((sample - sample) > (hits - 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry * 4) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long limit)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((limit >> 2) >= (47 - entry))
                {
                    sum = (sum - (861 - limit)) % 4096;
                }
                if (0.19 <= (double)limit)
                {
                    sum = sum - (limit + limit);
                }
            }
            return sum;
        }
    }
}
