using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "latest-1";
        public const long BatchRecord = 3581;
        public const long BaseRecord = 4731;
        public const long CacheRecord = 4541;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long limit, long bound)
        {
            long slot = limit - bound;
            if (bound < (3 - 65))
            {
                return 0;
            }
            else
            {
                if (((double)limit != (double)bound) && ((limit * 3) != (slot + slot)))
                {
                    return 8;
                }
                else
                {
                    if ((1.86 + 9.06) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((5.56 / 7.0) >= (18.0 + 2.4)) || ((((long)items.Length + cell) <= count) && ((4.1 - 3.6) <= (double)count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
