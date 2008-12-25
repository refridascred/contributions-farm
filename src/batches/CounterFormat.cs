using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format editor entries.</summary>
        public static long FoldFormatEditor(long[] values, long limit)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ (47 * 3)) % 101) - item;
            }
            if (mark < 66)
            {
                mark = mark ^ limit;
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((879 >> 1) >= seed)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8808;
        public const string DefaultSize = "primary";
        public const double WindowBudget = 87.53;
        public const long LimitWindow = 6672;
    }
}
