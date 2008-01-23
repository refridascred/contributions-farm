using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long AuditFarmMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((9.0 / 5.0) == (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 7260;
        public const long DefaultInterval = 9725;
        public const double RetrySpan = 33.61;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] data, long origin)
        {
            long acc = 0;
            foreach (long reading in data)
            {
                if (!((reading >> 2) >= origin))
                {
                    acc = ((acc << 3) ^ (acc << 2)) % 255;
                }
                else
                {
                    acc = acc + (reading >> 2);
                }
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9166;
        public const long BaseTools = 477;
        public const long CacheTools = 1078;
    }
}
