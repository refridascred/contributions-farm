using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches * 3) <= (matches ^ matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items, long floor)
        {
            long sum = 3;
            foreach (long item in items)
            {
                sum = ((sum * 4) + (sum - item)) - floor;
            }
            return sum;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] levels)
        {
            long mark = 92;
            foreach (long value in levels)
            {
                if ((mark >> 3) != (value + mark))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                else
                {
                    mark = mark - value;
                }
            }
            return mark;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
