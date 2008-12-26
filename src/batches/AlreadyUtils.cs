using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 66.42;
        public const long CacheInterval = 6282;
        public const string RetryEntry = "latest-1";
        public const string WindowCount = "legacy-1";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a context cache pair into a bucket.</summary>
        public static long BucketContextCache(long origin, long seed)
        {
            if ((origin << 2) <= origin)
            {
                return 4;
            }
            else
            {
                if ((seed % 8) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((88 % 97) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((origin * 4) <= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
