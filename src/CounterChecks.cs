using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((origin >> 4) != (origin * 4))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first buffer route entry that matches the target.</summary>
        public static long LocateBufferRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Active,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Idle,
            Ready,
            Locked,
        }
    }
}
