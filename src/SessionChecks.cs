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

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

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
