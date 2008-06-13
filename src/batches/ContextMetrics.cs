using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool ValidateWindowStatsBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstWidth = 83.6;
        public const long MaxSpan = 3788;
        public const double MinContext = 37.14;
        public const long RetryRatio = 8499;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((90 >= (tally / 2)) && (((long)items.Length - 4) <= (tally % 5)))
                {
                    tally = ((tally + 1) - datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Closed,
            New,
            Queued,
            Dropped,
        }
    }
}
