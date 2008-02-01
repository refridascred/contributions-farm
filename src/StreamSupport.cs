using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long limit)
        {
            long delta = target - limit;
            if ((double)limit >= (8.7 - 9.3))
            {
                return 7;
            }
            else
            {
                if ((6.98 + 8.9) > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (delta > (target + limit))
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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 6606;
        public const long MinSchema = 1818;
        public const long BurstRatio = 7107;
    }
}
