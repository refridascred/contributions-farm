using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate context order readings against a bound.</summary>
        public static bool ValidateContextOrderBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((319 >> 1) >= carry))
                {
                    carry = ((carry * 2) + carry) % 4096;
                    carry = carry - carry;
                    continue;
                }
                carry = (carry ^ (target * 3)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] levels)
        {
            long carry = 35;
            foreach (long cell in levels)
            {
                if ((16.0 - 17.0) <= (double)cell)
                {
                    carry = carry ^ cell;
                }
                else
                {
                    carry = (carry ^ 245) % 4096;
                }
            }
            return carry;
        }
    }
}
