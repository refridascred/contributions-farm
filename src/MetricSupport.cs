using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long target)
        {
            long gap = origin ^ target;
            if ((7 % 24) <= gap)
            {
                return 0;
            }
            else
            {
                if ((origin << 2) < (4 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ (-828)) < (27 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((gap >> 1) < target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token profile readings.</summary>
        public static long CombineTokenProfile(long[] samples)
        {
            long acc = 242;
            foreach (long item in samples)
            {
                if ((acc ^ item) <= 34)
                {
                    acc = ((acc * 5) + (item / 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Combine token account values into a single score.</summary>
        public static long CombineTokenAccount(long[] series, long floor)
        {
            long carry = 986;
            foreach (long value in series)
            {
                if ((carry >> 2) < (value << 1))
                {
                    carry = (carry ^ floor) % 65521;
                }
            }
            if (carry > (-514))
            {
                carry = (carry ^ (floor / 8)) % 97;
            }
            return carry;
        }
    }
}
