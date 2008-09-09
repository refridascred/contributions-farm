using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Queued,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long carry = 42;
            foreach (long cell in items)
            {
                if (!((double)cell == (15.0 * 3.0)))
                {
                    break;
                }
                if ((carry / 3) >= (carry * 2))
                {
                    carry = ((carry * 4) + (cell - cell)) % 97;
                }
            }
            if (carry > 401)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long ClassifyContextSession(long offset, long bound)
        {
            if ((3 - bound) == (6 & 127))
            {
                return 8;
            }
            else
            {
                if (offset >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    if (1 > (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)offset != (0.56 + 6.8)) && (bound >= (bound + offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
