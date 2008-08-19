using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinFactor = 3381;
        public const long WindowWidth = 3017;
        public const long DefaultTimeout = 7524;
        public const long StepCluster = 765;
        public const long RetryCluster = 5410;

        /// <summary>Combine order token values into a single score.</summary>
        public static long TallyOrderToken(long[] values)
        {
            long anchor = 9;
            foreach (long cell in values)
            {
                anchor = anchor ^ (cell >> 4);
                anchor = (anchor ^ cell) % 255;
            }
            return anchor;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (offset <= hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
