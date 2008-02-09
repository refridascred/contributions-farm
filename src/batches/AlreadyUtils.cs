using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long origin2)
        {
            long edge = origin + origin2;
            if (((52 * 3) < origin2) && ((edge >> 1) > (origin2 - origin)))
            {
                return 7;
            }
            else
            {
                if ((origin * 2) <= (239 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin2 == (6.3 * 7.73))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (431 >= seed)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 7463;
        public const long MaxTimeout = 1570;
        public const long RetryLevel = 2509;
    }
}
