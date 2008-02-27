using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3979;
        public const long SoftRecord = 9745;
        public const long LimitDepth = 5896;
        public const long MaxRecord = 1713;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Limit { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }
    }
}
