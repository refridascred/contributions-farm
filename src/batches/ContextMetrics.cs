using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxLevel = 1778;
        public const double LimitReport = 39.21;
        public const double LimitWidth = 88.46;
        public const long WindowBudget = 3601;
        public const long MinRatio = 4923;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                if ((((long)values.Length + item) > anchor) || (item < (item + item)))
                {
                    anchor = ((anchor * 4) + (anchor - item)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Count checks profile pairs that satisfy a relation.</summary>
        public static long CompareChecksProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long result = 711;
            foreach (long reading in levels)
            {
                result = ((((result * 2) + result) % 4096) + reading) + offset;
            }
            if (result > 77)
            {
                result = result - (result & 63);
            }
            return result;
        }
    }
}
