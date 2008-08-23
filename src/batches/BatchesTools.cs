using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target - target) > ((long)i ^ 916))
                {
                    carry = ((carry << 3) ^ (carry / 6)) % 101;
                }
                else
                {
                    carry = carry - (carry - target);
                }
                carry = (carry ^ (target * 4)) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((23 & 255) >= (count & 31))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
