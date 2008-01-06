using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next batch payload value from a seed.</summary>
        public static long IterateBatchPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry - (bound + carry)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            New,
            Ready,
            Queued,
        }
    }
}
