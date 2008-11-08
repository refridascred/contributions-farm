using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            Queued,
            Idle,
            Draft,
            Synced,
        }
    }
}
