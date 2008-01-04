using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - result;
                result = (result * 5) + result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long state = -4;
            foreach (long reading in samples)
            {
                if (reading >= state)
                {
                    state = state + (state % 3);
                }
            }
            return state;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long origin)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading ^ 1)) % 101;
                carry = (carry ^ (origin % 3)) % 101;
            }
            return carry;
        }
    }
}
