using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.0 - 7.8) > (double)count)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long carry = 26;
            foreach (long item in levels)
            {
                if (!(item <= (origin ^ origin)))
                {
                    carry = (carry ^ (item & 15)) % 101;
                }
                carry = (carry + origin) % 97;
                if ((double)item >= 11.0)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
