using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) < reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                if (!((carry * 3) < carry))
                {
                    carry = ((carry ^ (1 << 1)) % 255) + reading;
                }
                else
                {
                    carry = carry - 8;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)24 > (double)tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
