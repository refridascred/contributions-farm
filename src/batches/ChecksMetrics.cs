using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (6.9 <= (double)bound)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Failed,
            Active,
            New,
            Closed,
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((15.0 - 8.16) <= (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
