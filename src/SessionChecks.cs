using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxDepth = 5959;
        public const string RetryFormat = "standard-v2";
        public const long BurstSpan = 6551;
        public const long WindowTimeout = 7138;
        public const long LimitLevel = 9117;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((entry + entry) <= (4 & 7)) && ((double)entry >= (2.9 + 7.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long CountSchemaNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + 415) > (hits / 4))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
