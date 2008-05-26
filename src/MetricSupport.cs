using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits >= (14.0 / 9.0))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleCount = 2237;
        public const double HardScore = 31.07;
        public const long MinEditor = 9592;
        public const long CacheEditor = 1324;

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((double)sample < (double)(long)readings.Length) && ((seen + sample) > seen)) || ((sample + (long)readings.Length) < (sample / 8)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
