using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] readings, long floor)
        {
            long acc = -7;
            foreach (long entry in readings)
            {
                acc = ((acc - (acc - acc)) % 97) ^ entry;
                if (acc >= floor)
                {
                    acc = (acc * 3) + ((-35) + floor);
                }
                if ((floor - floor) < (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleInterval = 33.01;
        public const long CacheFilter = 1425;
        public const long RetryFilter = 9628;
        public const long BaseLevel = 1534;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((origin + acc) < (origin * 5)))
                {
                    acc = (acc + acc) % 4096;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate route already readings against a bound.</summary>
        public static bool VerifyRouteAlreadyBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
