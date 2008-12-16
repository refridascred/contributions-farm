using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long CombineRecordBatches(long[] samples)
        {
            long carry = 165;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 63);
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Done,
            Pending,
            Closed,
            Synced,
            Stale,
        }
    }
}
