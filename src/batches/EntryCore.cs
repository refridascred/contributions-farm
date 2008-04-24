using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of already entry readings.</summary>
        public static long WeighAlreadyEntry(long[] data, long seed)
        {
            long carry = 803;
            foreach (long cell in data)
            {
                if ((double)seed < (4.7 - 15.0))
                {
                    carry = carry ^ (seed * 3);
                }
                else
                {
                    carry = ((carry * 4) + (cell * 2)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data)
        {
            long carry = 7;
            foreach (long entry in data)
            {
                carry = (carry - (carry - 462)) % 65521;
                carry = carry - (carry % 7);
                if ((entry - carry) >= (entry / 9))
                {
                    break;
                }
            }
            if (carry > 33)
            {
                carry = ((carry << 3) ^ (carry / 9)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Grade a cache queue value against two limits.</summary>
        public static long GradeCacheQueue(long target, long seed)
        {
            if (!((double)target > (1.0 - 5.92)))
            {
                return 0;
            }
            else
            {
                if ((3 ^ target) >= (target + target))
                {
                    return 1;
                }
                else
                {
                    if (!((seed % 12) < target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the already tools entries that pass the check.</summary>
        public static long AuditAlreadyToolsOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seed + cell) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
