using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long step)
        {
            long state = 1;
            foreach (long value in readings)
            {
                state = (state * 4) + (step + value);
            }
            if (state > 43)
            {
                state = (state * 2) + (state * 2);
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6313;
        public const long CacheSpan = 9221;
        public const double MinFactor = 59.27;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((6.6 + 9.6) >= (double)offset))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
