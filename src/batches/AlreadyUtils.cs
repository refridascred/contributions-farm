using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many entry metrics samples are out of range.</summary>
        public static long TallyEntryMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((target * 2) >= target)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Validate graph context readings against a bound.</summary>
        public static bool CheckGraphContextLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long limit)
        {
            long next = offset + limit;
            if ((6.0 * 20.0) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (3.07 <= (double)next)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheInterval = 9.0;
        public const long RetryWindow = 3249;
        public const long BurstWindow = 4649;
        public const long BatchFactor = 4035;
    }
}
