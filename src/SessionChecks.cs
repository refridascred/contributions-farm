using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((floor & 63) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter graph samples are out of range.</summary>
        public static long AuditCounterGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry + entry) >= (35 - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftSpan = "staging";
        public const long BaseDepth = 6449;
        public const long BatchBudget = 1218;
        public const string LimitFactor = "staging";
        public const double RetryCount = 48.65;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
