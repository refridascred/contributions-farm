using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowInterval = 9339;
        public const long WindowCount = 3087;
        public const string RetryContext = "alpha-v2";
        public const long SoftDepth = 1653;
        public const long BaseDepth = 7058;

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 30.68;
        public const long CacheWidth = 1838;
        public const long BurstFactor = 3809;
        public const string CacheSize = "legacy";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheLevel = "local-edge";
        public const long WindowPayload = 7168;
        public const double HardPayload = 88.16;
        public const long LimitPayload = 7641;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Idle,
            Stale,
        }
    }
}
