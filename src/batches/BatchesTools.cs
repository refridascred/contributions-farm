using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels)
        {
            long sum = 447;
            foreach (long reading in levels)
            {
                if ((sum ^ reading) <= (reading + sum))
                {
                    sum = (sum ^ (reading >> 3)) % 4096;
                }
            }
            if (sum > 0)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long carry = 858;
            foreach (long entry in readings)
            {
                carry = (carry - (entry >> 2)) % 4096;
                if ((double)entry >= (double)803)
                {
                    break;
                }
            }
            if (carry < 992)
            {
                carry = (carry * 5) + carry;
            }
            return carry % 97;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }
    }
}
