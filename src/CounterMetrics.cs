using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long IdleCommits = 1864;
        public const long BurstCommits = 6962;
        public const long MaxCommits = 1077;

        /// <summary>Locate a metric format reading by value.</summary>
        public static long LookupMetricFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + offset) == (item * 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
