using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 680;
            foreach (long cell in values)
            {
                if ((cell >> 5) <= cell)
                {
                    carry = (carry + (carry ^ 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (origin / 6)) % 101;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
