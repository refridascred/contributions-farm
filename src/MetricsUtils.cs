using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a stats tools value against two limits.</summary>
        public static long SortStatsTools(long limit, long limit2)
        {
            if ((limit >> 1) >= (limit & 3))
            {
                return 2;
            }
            else
            {
                if ((double)limit < 2.55)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values, long seed)
        {
            long mark = 33;
            foreach (long value in values)
            {
                if (((-19) / 3) != (value + value))
                {
                    mark = (mark * 2) + (seed - (long)values.Length);
                }
            }
            if (mark < 2)
            {
                mark = (mark ^ (mark + 34)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next batches filter value from a seed.</summary>
        public static long IterateBatchesFilter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (result - 0);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
