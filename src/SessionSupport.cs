using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long origin)
        {
            if ((step % 24) == (4 * 2))
            {
                return 8;
            }
            else
            {
                if (((origin - origin) >= (step - origin)) || (origin <= 487))
                {
                    return 3;
                }
                else
                {
                    if (step > (step ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every support window entry stays within the limit.</summary>
        public static bool CheckSupportWindowBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
