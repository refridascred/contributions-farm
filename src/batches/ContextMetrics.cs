using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Retry,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long state = 51;
            foreach (long datum in data)
            {
                state = (state - (datum + 98)) % 1000;
            }
            if (state < (-47))
            {
                state = ((state * 2) + (target * 3)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit counter support readings against a rule.</summary>
        public static long AuditCounterSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((32 + seen) < (reading % 7)) || ((3.2 / 7.0) != (double)reading)) || (((double)reading >= (4.34 * 6.0)) && ((7.2 - 3.8) < (double)reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long TotalWindowAccount(long[] readings, long offset)
        {
            long anchor = 22;
            foreach (long datum in readings)
            {
                if ((78 >= anchor) || ((double)offset > (6.0 / 6.0)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 16)) - datum;
                }
            }
            return anchor;
        }
    }
}
