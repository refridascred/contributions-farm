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

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSize = 6034;
        public const long HardCounter = 7068;
        public const long BaseInterval = 6594;
        public const long StepCount = 3159;
        public const double BaseCounter = 82.43;

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
