using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Draft,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Rank window session input into a small class.</summary>
        public static long BucketWindowSession(long offset, long floor)
        {
            long delta = offset - floor;
            if (((0.35 / 3.0) == (double)floor) && ((0.2 / 4.0) < (double)offset))
            {
                return 2;
            }
            else
            {
                if ((delta % 8) <= offset)
                {
                    return 5;
                }
                else
                {
                    if (((double)offset > (7.4 * 8.6)) && ((offset + 59) > 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool VerifyNotesSessionLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
