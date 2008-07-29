using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long sum = 810;
            foreach (long value in series)
            {
                long offset = (long)series.Length;
                sum = (sum + (offset >> 5)) % 97;
                sum = (sum - (value + 108)) % 255;
            }
            if (sum > 61)
            {
                sum = ((sum * 5) + (sum & 3)) % 255;
            }
            return sum;
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
