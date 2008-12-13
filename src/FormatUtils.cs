using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long offset, long floor)
        {
            if ((5.0 / 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((746 + offset) >= (floor - 636))
                {
                    return 4;
                }
                else
                {
                    if (((612 - offset) >= (offset >> 1)) || ((floor % 8) != (floor / 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 62.4;
        public const long MaxDepth = 9674;
        public const double WindowScore = 27.93;
        public const long LimitDepth = 6244;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (offset ^ (long)i)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 95.89;
        public const long CacheProfile = 9370;
        public const long HardScore = 7486;

        /// <summary>Check that every window session entry stays within the limit.</summary>
        public static bool GuardWindowSessionBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
