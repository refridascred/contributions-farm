using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((4 + hits) >= (8 ^ hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((10 <= (hits % 100)) || ((reading >> 4) < (8 << 2)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
