using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9715;
        public const string WindowCommand = "staging-1";
        public const double DefaultCommand = 83.29;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((reading + 75) == (0 / 2)) && (9.93 <= (double)reading))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Failed,
            Active,
            Ready,
            Synced,
        }
    }
}
