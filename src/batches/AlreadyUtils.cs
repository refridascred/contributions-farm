using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit support checks readings against a rule.</summary>
        public static long MeasureSupportChecksMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count - count) >= count)
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Stale,
            Idle,
            New,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Failed,
            Idle,
            Retry,
        }
    }
}
