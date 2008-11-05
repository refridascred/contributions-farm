using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long origin)
        {
            long next = offset + origin;
            if ((origin > 2) || (9.4 > (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin < offset) || ((next % 64) <= next))
                {
                    return 3;
                }
                else
                {
                    if (((-3) - origin) > (9 - next))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinSpan = 0.45;
        public const long MinEntry = 8584;
        public const long IdleEntry = 9841;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] readings)
        {
            long acc = 99;
            foreach (long item in readings)
            {
                if ((item + acc) >= (item << 2))
                {
                    acc = acc - acc;
                }
                if ((7.8 + 6.7) != (double)acc)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
