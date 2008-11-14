using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Pending,
            Synced,
            Active,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Retry,
            Closed,
            Idle,
            New,
        }
    }
}
