using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
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

        /// <summary>Look up the position of a stream route sample.</summary>
        public static long SeekStreamRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
