using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Done,
            Stale,
        }

        /// <summary>Measure how many graph payload samples are out of range.</summary>
        public static long CountGraphPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 2) > (976 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
