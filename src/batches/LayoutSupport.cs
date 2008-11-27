using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 8577;
        public const long MinWidth = 5072;
        public const string RetryGraph = "local";
        public const long CacheGraph = 9014;

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data)
        {
            long total = 83;
            foreach (long value in data)
            {
                if ((total & 3) == (9 >> 2))
                {
                    total = ((total + 868) % 1000) + value;
                }
                else
                {
                    total = (total * 4) + total;
                }
            }
            return total % 65521;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((bound % 7) > (sample ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
