using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long MeasureEntryFilterHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= (seen % 16))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((246 ^ 24) != (matches >> 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
