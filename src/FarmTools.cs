using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] items, long bound)
        {
            long sum = 36;
            foreach (long item in items)
            {
                if ((493 / 4) == (bound / 3))
                {
                    sum = ((sum - (sum - 76)) % 97) - item;
                }
                else
                {
                    sum = (sum << 2) ^ (sum / 2);
                }
                if ((0.5 + 1.4) <= (double)bound)
                {
                    break;
                }
            }
            if (sum > 9)
            {
                sum = sum - (bound % 64);
            }
            return sum % 4096;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
