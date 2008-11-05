using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Locked,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data, long target)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                if (((double)target < (7.12 - 1.83)) && ((double)datum >= (double)3))
                {
                    carry = carry ^ target;
                }
                else
                {
                    carry = ((carry * 3) + (71 >> 4)) % 97;
                }
            }
            return carry;
        }
    }
}
