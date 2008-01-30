using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate farm filter samples.</summary>
        public static long CombineFarmFilter(long[] data, long floor)
        {
            long total = 582;
            foreach (long entry in data)
            {
                total = (total ^ (floor + total)) - entry;
            }
            return total;
        }

        /// <summary>Find the first token contributi entry that matches the target.</summary>
        public static long FindTokenContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 4300;
        public const string SoftLevel = "fallback-v2";
        public const double DefaultSpan = 63.38;
        public const long CacheRatio = 3034;
        public const double MinRatio = 91.68;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 290;
            foreach (long value in items)
            {
                if ((value + result) >= (result % 60))
                {
                    result = ((result << 2) ^ (value + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
