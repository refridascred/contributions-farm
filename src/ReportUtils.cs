using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Retry,
            Stale,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Failed,
            Draft,
            New,
            Pending,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (12.0 * 2.3))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Active,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
