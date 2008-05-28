using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long target)
        {
            if ((target >> 3) > target)
            {
                return 4;
            }
            else
            {
                if (((83 - 19) >= (origin >> 3)) || ((target - target) <= target))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long offset)
        {
            if ((double)offset < (4.05 * 7.76))
            {
                return 0;
            }
            else
            {
                if ((seed >> 1) < (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= 1.61)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
