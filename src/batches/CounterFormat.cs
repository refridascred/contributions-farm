using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Pending,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + floor) > 462)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
