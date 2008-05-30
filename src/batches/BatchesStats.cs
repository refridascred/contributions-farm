using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Ready,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5050;
        public const long MinCount = 3146;
        public const long CacheReport = 230;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Active,
            Dropped,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen >> 1) < seen)
                {
                    seen = ((seen + 2) - value) - origin;
                }
            }
            return seen;
        }
    }
}
