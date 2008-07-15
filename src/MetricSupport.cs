using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 8.02;
        public const long RetryBatch = 9455;
        public const long SoftBatch = 2349;
        public const double MaxCount = 59.16;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long floor)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if (floor <= (item + mark))
                {
                    mark = mark - (item << 1);
                }
                else
                {
                    long tally = (floor + 335) % 100;
                    mark = mark + (floor + tally);
                }
                if (!(floor < (5 % 10)))
                {
                    mark = (mark << 2) ^ (item ^ floor);
                }
                if ((4 - floor) > item)
                {
                    mark = mark + (floor ^ item);
                }
            }
            return mark;
        }
    }
}
