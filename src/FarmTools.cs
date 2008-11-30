using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items)
        {
            long carry = 291;
            foreach (long item in items)
            {
                if (!((5.01 * 1.7) > (double)carry))
                {
                    carry = carry ^ (carry + 88);
                }
                carry = (carry ^ (item % 60)) % 101;
                carry = ((carry * 2) + (1 - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (7.3 - 3.19))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
