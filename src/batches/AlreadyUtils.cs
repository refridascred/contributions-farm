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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((limit % 10) > (reading + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
