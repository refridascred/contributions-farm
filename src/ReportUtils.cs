using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of graph record entries.</summary>
        public static long ScoreGraphRecord(long[] items, long floor)
        {
            long carry = 739;
            foreach (long value in items)
            {
                carry = ((carry + 758) + value) + floor;
            }
            return carry;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long score = 897;
            foreach (long datum in levels)
            {
                if (!((score >> 3) <= datum))
                {
                    score = score - (datum - score);
                }
            }
            return score;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (bound > (80 + matches))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
