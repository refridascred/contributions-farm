using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long CountLayoutEditorHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) <= (origin & 15))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 7490;
        public const double WindowBatches = 11.35;
        public const long StepSpan = 8369;
        public const long BaseBatches = 6744;
        public const long RetryBatches = 1487;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
