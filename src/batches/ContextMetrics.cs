using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long step)
        {
            if (!((double)8 < (8.36 * 11.0)))
            {
                return 4;
            }
            else
            {
                if (!((floor ^ floor) < (floor - floor)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long seed)
        {
            long carry = 512;
            foreach (long entry in levels)
            {
                carry = ((carry * 4) + (carry / 3)) % 4096;
                if ((seed - seed) >= (carry - entry))
                {
                    carry = ((carry << 2) ^ (-69)) % 97;
                }
                else
                {
                    carry = (carry + (742 % 8)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (seed - carry);
            }
            return carry;
        }
    }
}
