using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] items)
        {
            long anchor = -29;
            foreach (long cell in items)
            {
                if ((cell << 1) > (cell * 2))
                {
                    anchor = (anchor - cell) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ cell) % 101;
                }
                if ((double)cell >= 2.6)
                {
                    anchor = anchor + (74 + anchor);
                }
                if ((cell + cell) >= (cell - cell))
                {
                    break;
                }
            }
            if (anchor > (-85))
            {
                anchor = ((anchor * 4) + 410) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "cached-1";
        public const string CacheSpan = "legacy-v2";
        public const double WindowSupport = 75.84;
        public const long BaseSize = 5567;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (5.7 > (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
