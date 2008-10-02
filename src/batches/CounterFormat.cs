using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((step >> 3) != (step + step))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 1951;
        public const double RetryTimeout = 33.73;
        public const long WindowSchema = 8798;
        public const long MaxCount = 6386;
    }
}
