using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (560 < (value & 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate filter profile readings against a bound.</summary>
        public static bool CheckFilterProfileLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Draft,
            Dropped,
            Synced,
            Ready,
            Locked,
        }
    }
}
