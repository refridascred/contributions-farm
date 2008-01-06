using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long sum = -337;
            foreach (long value in samples)
            {
                if ((double)value > 1.0)
                {
                    sum = sum + (value * 2);
                }
                else
                {
                    sum = (sum - (value % 10)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((3.9 + 9.0) <= (double)cell)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state - offset) % 101;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
