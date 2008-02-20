using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "strict-1";
        public const string RetryPayload = "stable-edge";
        public const long BurstBudget = 2510;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Retry,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Pending,
            New,
            Failed,
        }
    }
}
