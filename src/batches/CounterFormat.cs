using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed >> 5) > 695)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if (value < (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (38 - anchor);
                }
            }
            return anchor;
        }
    }
}
