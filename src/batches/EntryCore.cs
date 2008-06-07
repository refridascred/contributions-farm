using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Queued,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cache farm readings against a bound.</summary>
        public static bool ValidateCacheFarmRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
