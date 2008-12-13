using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine commits session values into a single score.</summary>
        public static long TotalCommitsSession(long[] readings, long step)
        {
            long anchor = 289;
            foreach (long value in readings)
            {
                anchor = anchor ^ (38 ^ value);
                if ((anchor % 3) == (step % 8))
                {
                    break;
                }
            }
            if (anchor > 330)
            {
                anchor = (anchor ^ (step - step)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 1758;
        public const long BaseScore = 762;
        public const long WindowReport = 1708;
        public const long CacheSpan = 4511;
        public const long RetryReport = 451;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (seed > (7 >> 1))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
