using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((double)cell == (20.0 * 1.9)) && (matches < (cell / 8)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
