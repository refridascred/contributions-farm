using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Idle,
            Locked,
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

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] readings, long seed)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if ((double)anchor >= (double)seed)
                {
                    anchor = (anchor << 3) ^ (entry + entry);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor % 60)) % 1000;
                }
            }
            if (anchor > 15)
            {
                anchor = (anchor - (seed ^ seed)) % 4096;
            }
            return anchor;
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
