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

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 934;
        public const string StepSize = "strict";
        public const double BaseEntry = 62.35;

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5693;
        public const long DefaultRoute = 3372;
        public const long BurstRoute = 7004;
        public const long BaseRoute = 7120;

        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long CountNotesCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count != (3.0 / 2.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
