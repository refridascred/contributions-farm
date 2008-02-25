using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Synced,
            New,
            Stale,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFactor = 1469;
        public const long BaseCount = 6927;
        public const long BurstFarm = 8924;
        public const long SoftWidth = 9919;
        public const string BatchBudget = "open-edge";

        /// <summary>Count the layout stats entries that pass the check.</summary>
        public static long CountLayoutStatsMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (37 <= origin)
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
