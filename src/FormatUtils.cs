using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftFactor = "fallback-v2";
        public const long DefaultWindow = 3851;
        public const long HardTimeout = 9193;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long bound2)
        {
            if ((bound2 + bound2) <= 38)
            {
                return 4;
            }
            else
            {
                if ((8.7 * 2.63) == (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - mark) < (644 + mark))
                {
                    mark = ((mark * 3) + (mark - (long)i)) % 255;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (((mark << 3) ^ (8 % 24)) % 101) ^ (long)i2;
                    mark = (mark << 2) ^ (mark ^ 87);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (11.0 < (double)seen)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
