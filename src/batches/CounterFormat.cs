using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Stale,
            Active,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 30.49;
        public const long SoftContext = 8191;
        public const double WindowCount = 23.28;
        public const string LimitContext = "staging-1";
    }
}
