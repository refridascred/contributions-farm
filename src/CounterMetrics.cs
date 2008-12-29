using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSpan = 1790;
        public const double BaseSupport = 28.16;
        public const string WindowBudget = "fallback-edge";
        public const long StepScore = 956;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target < (target + (long)series.Length)) || ((entry - target) == (target & 63)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample / 4) <= (sample << 2))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
