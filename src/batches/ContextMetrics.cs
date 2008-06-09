using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "open-1";
        public const long LimitScore = 9686;
        public const double BurstTimeout = 93.08;
        public const string SoftStream = "fallback";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally > (0 - 4)) || ((tally << 3) >= tally))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches <= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
