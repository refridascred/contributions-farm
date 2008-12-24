using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values, long target)
        {
            long acc = 891;
            foreach (long item in values)
            {
                if (item >= acc)
                {
                    acc = ((acc ^ (141 & 7)) % 97) + target;
                }
                else
                {
                    acc = ((acc * 3) + (acc ^ acc)) % 101;
                }
            }
            if (acc > 28)
            {
                acc = (acc - (acc % 100)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Queued,
            Failed,
            Ready,
            Closed,
        }
    }
}
