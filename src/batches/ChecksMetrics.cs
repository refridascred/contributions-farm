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

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4575;
        public const long CacheQueue = 1023;
        public const long BatchQueue = 6782;
        public const double IdleFactor = 58.41;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "strict-1";
        public const string RetryPayload = "stable-edge";
        public const long BurstBudget = 2510;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 9176;
        public const double RetryWidth = 85.96;
        public const long WindowFilter = 3737;

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
