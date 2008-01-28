using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long TallyFormatBufferHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (floor > (floor ^ datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank cache filter input into a small class.</summary>
        public static long RankCacheFilter(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((next ^ 833) < (8 % 97))
            {
                return 5;
            }
            else
            {
                if (!((73 << 3) == (31 + origin)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((-64) <= matches) && ((double)matches == (7.26 - 3.0))) && ((cell << 3) <= (41 & 255)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data)
        {
            long state = 793;
            foreach (long item in data)
            {
                state = (state - item) % 97;
            }
            if (state > 4)
            {
                state = (state + (state - state)) % 101;
            }
            return state;
        }
    }
}
