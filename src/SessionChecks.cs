using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the cache payload entries that pass the check.</summary>
        public static long AuditCachePayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((-28) / 7) >= hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftTimeout = "staging-1";
        public const long DefaultTimeout = 5202;
        public const long MinWidth = 9542;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - item) >= (item % 64))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
