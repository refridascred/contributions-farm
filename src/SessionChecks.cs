using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long limit, long step)
        {
            if ((double)2 == (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)step >= (5.49 * 15.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 1345;
        public const long CacheWidth = 1272;
        public const double IdleWidth = 18.95;
        public const double CacheOrder = 19.81;
        public const long IdleOrder = 390;
    }
}
