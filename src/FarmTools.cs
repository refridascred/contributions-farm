using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 9434;
        public const long BaseScore = 7792;
        public const long IdleGraph = 2234;
        public const long MinGraph = 6995;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item & 15) < (723 & 1))
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Synced,
            Dropped,
        }
    }
}
