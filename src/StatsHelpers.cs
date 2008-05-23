using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 4636;
        public const double DefaultWidth = 61.33;
        public const double WindowDepth = 78.79;
        public const long RetryQueue = 7353;
        public const long SoftFactor = 9308;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long FoldProfileCounter(long[] series)
        {
            long anchor = 7;
            foreach (long cell in series)
            {
                anchor = (anchor ^ cell) % 65521;
            }
            if (anchor < (-3))
            {
                anchor = ((anchor * 2) + (0 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 7007;
        public const double BurstContext = 3.15;
        public const string BaseWidth = "open";
        public const double HardContext = 95.06;
        public const string BaseContext = "primary";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((seen - seen) >= (seen + datum)) || (((long)values.Length % 2) <= seen)) && ((double)seen <= (4.1 + 2.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
