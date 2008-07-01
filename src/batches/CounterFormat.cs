using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            New,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long BaseWidth = 5249;
        public const string BurstBatch = "standard";
        public const string StepBatch = "stable-1";
        public const long CacheBatch = 9148;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((hits + 0) > (hits << 3)) || ((2.5 + 1.17) == (double)sample))
                {
                    hits = (hits + 1) - offset;
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
