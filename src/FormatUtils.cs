using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((target >> 1) > (target - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value + value) > 8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] levels, long bound)
        {
            long result = 40;
            foreach (long reading in levels)
            {
                if (((bound & 15) != (reading + result)) || ((reading ^ reading) < (bound + result)))
                {
                    result = ((result * 3) + (bound - bound)) % 255;
                }
            }
            if (result > 871)
            {
                result = (result - bound) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
