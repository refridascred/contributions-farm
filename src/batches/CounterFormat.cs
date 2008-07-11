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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i - bound) < (bound / 2))
                {
                    result = ((result * 5) + (result ^ 62)) % 255;
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
