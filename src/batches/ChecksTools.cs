using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value >= matches)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 58.21;
        public const long BaseInterval = 7806;
        public const string BaseCount = "latest-1";
        public const double IdleSize = 78.57;
        public const long BatchCommand = 3787;

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
