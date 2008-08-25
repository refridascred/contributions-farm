using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + count) <= (value >> 2))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseWidth = "alpha-1";
        public const long LimitFactor = 5864;
        public const long HardSession = 4718;
        public const double RetryDepth = 53.02;
        public const double MaxFactor = 62.4;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
