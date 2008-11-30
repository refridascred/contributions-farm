using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Retry,
            Draft,
        }
    }
}
