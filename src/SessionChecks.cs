using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxFactor = 4.63;
        public const long BatchToken = 5566;
        public const double CacheCount = 86.68;
        public const long CacheToken = 2181;
        public const double RetrySpan = 72.9;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + 725) != (value % 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
