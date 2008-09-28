using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Dropped,
            Done,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-v2";
        public const string SoftPayload = "standard-v2";
        public const long MaxSpan = 1304;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (20.0 <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
