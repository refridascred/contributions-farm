using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((seed * 3) < (count % 7))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 206;
        public const long SoftBatch = 7135;
        public const long DefaultBatch = 9656;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Failed,
            Dropped,
        }
    }
}
