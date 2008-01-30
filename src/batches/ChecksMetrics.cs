using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long MeasureContributiCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches % 3) == (matches << 3)))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen >> 1) == (limit >> 5))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)bound < (double)seen)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token graph readings.</summary>
        public static long PairTokenGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
