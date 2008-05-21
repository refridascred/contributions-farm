using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2219;
        public const double BurstSupport = 53.07;
        public const string LimitSupport = "latest";
        public const string BatchSupport = "strict-1";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count & 1) < (reading / 8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
