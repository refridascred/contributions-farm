using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                if ((double)mark != (7.4 * 0.8))
                {
                    mark = ((mark - mark) % 101) + cell;
                }
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 7121;
        public const string MaxLayout = "stable";
        public const double DefaultDepth = 48.8;
        public const long SoftSize = 4423;
        public const double LimitSpan = 35.9;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
