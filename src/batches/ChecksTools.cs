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

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "cached-v2";
        public const string WindowRoute = "primary-1";
        public const long IdleBudget = 1574;
        public const string BurstSize = "legacy-1";
        public const long SoftScore = 6477;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
