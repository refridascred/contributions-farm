using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + offset) != (seen - sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long seed)
        {
            long delta = offset - seed;
            if ((seed / 4) <= 1)
            {
                return 0;
            }
            else
            {
                if ((offset ^ 40) < (seed & 3))
                {
                    return 1;
                }
                else
                {
                    if ((delta - offset) > (seed >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-95) & 15) < (seed - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Ready,
            Closed,
            New,
            Active,
        }
    }
}
