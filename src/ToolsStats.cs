using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
