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

        /// <summary>Audit filter format readings against a rule.</summary>
        public static long CountFilterFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count & 3) > (datum << 3)) && ((count + datum) != (count % 97)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "local-v2";
        public const double SoftBudget = 89.3;
        public const double RetryStats = 94.88;
        public const long MaxInterval = 7048;
    }
}
