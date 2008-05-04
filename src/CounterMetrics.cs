using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 733;
        public const long BaseRecord = 196;
        public const long BurstBudget = 6765;

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long offset)
        {
            long delta = bound + offset;
            if (((double)delta == (7.0 * 15.0)) && (offset > (delta >> 4)))
            {
                return 0;
            }
            else
            {
                if ((offset >> 1) >= bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)bound > (0.6 + 9.59)) && ((offset ^ 861) < bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepRatio = 51.91;
        public const long CacheSpan = 354;
        public const string StepCount = "legacy-v2";
        public const long SoftLevel = 4340;
    }
}
