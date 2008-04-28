using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the account layout entries that pass the check.</summary>
        public static long MeasureAccountLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen < item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
