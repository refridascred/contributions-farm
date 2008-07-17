using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + 55) < (long)data.Length)
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }
    }
}
