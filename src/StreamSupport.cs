using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (tally + value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] values, long seed)
        {
            long mark = -385;
            foreach (long value in values)
            {
                mark = (mark - 6) % 101;
                if ((19.0 / 8.0) > (double)mark)
                {
                    mark = (mark + (value + seed)) % 4096;
                }
                else
                {
                    mark = mark + (9 - 2);
                }
            }
            return mark;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
