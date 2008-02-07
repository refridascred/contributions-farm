using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Retry,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Check that every buffer commits entry stays within the limit.</summary>
        public static bool CheckBufferCommitsLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
