using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (1.0 - 5.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long AuditStreamOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) > (3 - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
