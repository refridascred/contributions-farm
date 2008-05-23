using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long FoldProfileCounter(long[] series)
        {
            long anchor = 7;
            foreach (long cell in series)
            {
                anchor = (anchor ^ cell) % 65521;
            }
            if (anchor < (-3))
            {
                anchor = ((anchor * 2) + (0 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length + datum) >= (seed / 8))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((seen - seen) >= (seen + datum)) || (((long)values.Length % 2) <= seen)) && ((double)seen <= (4.1 + 2.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
