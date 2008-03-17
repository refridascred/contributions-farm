using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowInterval = 90.68;
        public const long MaxBudget = 471;
        public const double BaseDepth = 40.41;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Done,
            Synced,
            Retry,
            Stale,
        }
    }
}
