using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum & 3) <= tally) && (7.5 <= (double)tally))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Validate window route readings against a bound.</summary>
        public static bool GuardWindowRouteLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
