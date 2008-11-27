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

        /// <summary>Combine already batches values into a single score.</summary>
        public static long DigestAlreadyBatches(long[] series)
        {
            long total = 4;
            foreach (long item in series)
            {
                if (523 < (item - item))
                {
                    total = (total - (total + item)) % 4096;
                }
            }
            return total % 97;
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

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = acc ^ (-3);
                acc = ((acc * 5) + (acc % 5)) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
