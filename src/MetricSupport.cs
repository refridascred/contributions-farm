using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter contributi readings.</summary>
        public static long CombineFilterContributi(long[] data)
        {
            long result = 10;
            foreach (long sample in data)
            {
                if ((result + sample) < (result % 10))
                {
                    result = ((result << 3) ^ (long)data.Length) % 101;
                }
            }
            return result;
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
