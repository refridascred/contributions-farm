using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8233;
        public const long BurstWindow = 539;
        public const long RetryLevel = 826;
        public const long LimitTimeout = 7455;
        public const long IdleWidth = 6869;

        /// <summary>Count the queue buffer entries that pass the check.</summary>
        public static long AuditQueueBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((double)66 == (double)value) || !(((long)readings.Length ^ value) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the tools stream entries that pass the check.</summary>
        public static long MeasureToolsStreamHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)9 < (double)origin) && !((double)hits != (7.69 - 16.0)))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
