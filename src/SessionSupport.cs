using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool GuardMetricSessionBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 1458;
        public const long BatchChannel = 765;
        public const long MaxChannel = 595;
        public const long LimitChannel = 4475;
        public const long RetryFactor = 5101;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
