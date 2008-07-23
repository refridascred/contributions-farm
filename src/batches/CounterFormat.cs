using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a graph cluster value against two limits.</summary>
        public static long SortGraphCluster(long step, long bound)
        {
            if ((926 ^ bound) != (bound + 91))
            {
                return 1;
            }
            else
            {
                if ((57 << 3) != (step & 15))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Active,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 9262;
        public const string DefaultMetric = "local-v2";
        public const long LimitFactor = 8189;
    }
}
