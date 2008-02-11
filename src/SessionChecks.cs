using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Retry,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Failed,
            New,
            Draft,
        }
    }
}
