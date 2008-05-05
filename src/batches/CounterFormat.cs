using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5003;
        public const long LimitReport = 1556;
        public const long MinReport = 3794;
        public const long DefaultTimeout = 3012;
        public const long BaseTimeout = 4710;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry >= (14 - (-5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
