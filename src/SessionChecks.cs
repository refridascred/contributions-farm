using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally >> 3) < (limit + limit))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
