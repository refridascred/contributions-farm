using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "fallback";
        public const string BaseCount = "cached-edge";
        public const long HardCommand = 3919;
        public const long DefaultBudget = 1970;

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long TallyRoutePayloadOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < (item - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
