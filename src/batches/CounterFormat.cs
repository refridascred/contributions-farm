using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum > (datum % 16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 7461;
        public const long DefaultLevel = 7653;
        public const long BaseReport = 9978;
        public const long BaseWidth = 9498;

        /// <summary>Match up counter cache samples.</summary>
        public static long PairCounterCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
