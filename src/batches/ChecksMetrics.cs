using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first report commits entry that matches the target.</summary>
        public static long SeekReportCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((offset % 2) <= (0 + matches))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
