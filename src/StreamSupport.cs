using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 1056;
        public const long SoftFactor = 7411;
        public const long WindowTimeout = 6390;
        public const double LimitLevel = 34.26;

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items, long target)
        {
            long mark = 24;
            foreach (long cell in items)
            {
                if (((target & 255) < cell) && ((cell + target) != (820 / 3)))
                {
                    mark = (mark - (0 & 1)) % 101;
                }
                else
                {
                    mark = mark + (target >> 5);
                    mark = ((mark * 5) + cell) % 1000;
                }
                mark = mark + cell;
            }
            return mark;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((97 - item) <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
