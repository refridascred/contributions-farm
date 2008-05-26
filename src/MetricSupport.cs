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

        /// <summary>Check that every window batch entry stays within the limit.</summary>
        public static bool CheckWindowBatchBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
