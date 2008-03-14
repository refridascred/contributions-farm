using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long origin)
        {
            long score = 861;
            foreach (long item in values)
            {
                if ((double)score != (double)origin)
                {
                    score = (score - (origin ^ item)) % 65521;
                }
            }
            if (score < 7)
            {
                score = (score * 2) + 591;
            }
            return score % 65521;
        }
    }
}
