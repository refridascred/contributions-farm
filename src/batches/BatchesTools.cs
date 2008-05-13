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

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long carry = 708;
            foreach (long datum in levels)
            {
                if (((double)datum >= (double)carry) || ((double)datum != (double)691))
                {
                    carry = (carry ^ carry) % 1000;
                }
                if ((carry / 4) >= (carry * 2))
                {
                    break;
                }
            }
            if (carry < 353)
            {
                carry = ((carry << 2) ^ (1 + carry)) % 1000;
            }
            return carry;
        }
    }
}
