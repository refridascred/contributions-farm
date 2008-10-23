using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Synced,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long CountFormatTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (double)461))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            New,
            Synced,
            Done,
            Retry,
        }
    }
}
