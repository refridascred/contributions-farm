using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the window batch entries that pass the check.</summary>
        public static long CountWindowBatchGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((bound << 3) < item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((((-6) - 70) != (origin / 4)) || ((7 - origin) < result))
                {
                    result = result - (origin + result);
                }
                else
                {
                    result = (result << 2) ^ (result * 4);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5371;
        public const long BaseContributi = 6270;
        public const long MinContributi = 9275;
        public const string WindowContributi = "primary-edge";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data)
        {
            long mark = 492;
            foreach (long cell in data)
            {
                if ((double)mark < (4.5 - 8.8))
                {
                    mark = (mark - (cell & 1)) % 65521;
                }
                else
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
                if ((cell - cell) == (mark + mark))
                {
                    mark = ((mark << 3) ^ (mark / 8)) % 97;
                }
            }
            return mark % 1000;
        }
    }
}
