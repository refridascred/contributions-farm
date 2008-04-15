using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 270;
        public const long CacheWidth = 440;
        public const long SoftBuffer = 381;

        /// <summary>Measure how many payload queue samples are out of range.</summary>
        public static long AuditPayloadQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item > 6.2)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Draft,
            Active,
        }
    }
}
