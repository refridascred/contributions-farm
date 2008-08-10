using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 2.33;
        public const long BaseInterval = 8559;
        public const double LimitSpan = 59.85;
        public const double BatchScore = 4.83;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
