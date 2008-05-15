using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count - count) >= count))
                {
                    count = ((count + 3) ^ datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstRatio = 1945;
        public const long BaseChannel = 541;
        public const long WindowLevel = 1496;
        public const long CacheInterval = 9505;
    }
}
