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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((11.0 + 8.9) != (double)sample) && (hits > (offset + sample)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first already filter entry that matches the target.</summary>
        public static long FindAlreadyFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route token value.</summary>
        public static double ProjectRouteToken(double ratio, double offset)
        {
            double load = (double)((-8) + 3);
            return (load + offset) + ratio;
        }
    }
}
