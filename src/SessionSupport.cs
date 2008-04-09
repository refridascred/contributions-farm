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

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits << 3) <= (datum >> 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
