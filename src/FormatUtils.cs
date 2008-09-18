using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a graph queue reading by value.</summary>
        public static long FindGraphQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format editor readings.</summary>
        public static long CompareFormatEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Find the first order window entry that matches the target.</summary>
        public static long FindOrderWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster metrics series from a seed.</summary>
        public static long RollClusterMetrics(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (floor + 35)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry ^ (floor * 4)) % 97) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((18.0 + 5.5) < (double)datum)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
