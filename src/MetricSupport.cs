using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of order checks readings.</summary>
        public static long CombineOrderChecks(long[] series)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                anchor = ((anchor + (anchor << 3)) % 65521) - value;
            }
            return anchor % 1000;
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
