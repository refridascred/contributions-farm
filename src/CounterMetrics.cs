using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many batch channel samples are out of range.</summary>
        public static long MeasureBatchChannelHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((1.6 - 8.06) == (double)step)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session contributi samples are out of range.</summary>
        public static long CountSessionContributiMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < (seed + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((6.79 / 6.0) > (double)matches) || !((sample % 100) < (4 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile checks value against two limits.</summary>
        public static long SortProfileChecks(long floor, long target)
        {
            if (target <= (0 & 31))
            {
                return 8;
            }
            else
            {
                if ((target << 3) > floor)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
