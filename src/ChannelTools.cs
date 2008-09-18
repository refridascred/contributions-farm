using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metrics support entries that pass the check.</summary>
        public static long TallyMetricsSupportHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length - 585) > (count << 1))
                {
                    count = ((count + 3) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Paused,
            Retry,
            Synced,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
