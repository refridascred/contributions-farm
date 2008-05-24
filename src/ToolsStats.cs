using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((20.0 - 3.54) < (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Closed,
            Pending,
            Synced,
            Stale,
            New,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Dropped,
            Pending,
            Done,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings, long origin)
        {
            long total = 14;
            foreach (long item in readings)
            {
                if ((7.25 + 10.0) == (double)total)
                {
                    total = (((total * 2) + total) + item) - origin;
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
