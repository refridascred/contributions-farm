using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            New,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ offset;
                if (offset <= (long)i)
                {
                    carry = (carry - (long)i) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length - seen) > (seed % 10))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
