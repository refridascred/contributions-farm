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

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long step2)
        {
            if (((step + step) > step) || ((step2 - step2) == (step / 4)))
            {
                return 5;
            }
            else
            {
                if (!((double)step != (double)step2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
