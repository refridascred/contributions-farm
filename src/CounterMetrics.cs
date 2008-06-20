using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 6853;
        public const double MinEditor = 58.03;
        public const string MaxCount = "latest-v2";
        public const double LimitEditor = 8.6;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (long)values.Length)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
