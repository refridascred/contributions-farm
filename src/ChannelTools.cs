using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.0 + 16.0) <= (double)count)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Audit cluster token readings against a rule.</summary>
        public static long CountClusterTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item & 127) <= item)
                {
                    hits = hits + 1;
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
