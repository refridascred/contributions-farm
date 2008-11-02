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

        /// <summary>Locate a stream format reading by value.</summary>
        public static long LookupStreamFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
