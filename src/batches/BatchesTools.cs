using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long AuditCommitsRouteGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)item > (9.5 + 6.39)) || ((double)seed != (8.01 * 8.31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Synced,
            Locked,
            Done,
        }
    }
}
