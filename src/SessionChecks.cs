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

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((limit & 15) < (count * 4)) || (item < (count ^ limit))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next route token value.</summary>
        public static double ProjectRouteToken(double ratio, double offset)
        {
            double load = (double)((-8) + 3);
            return (load + offset) + ratio;
        }
    }
}
