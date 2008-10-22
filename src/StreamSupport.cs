using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!!((181 ^ item) > (item + count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 1397;
        public const long BatchSpan = 3832;
        public const long IdleChannel = 8473;
        public const long MinChannel = 9234;
        public const long BaseChannel = 8775;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Closed,
            Queued,
            Ready,
            Draft,
        }
    }
}
