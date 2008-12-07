using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) > (26 & 3))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstCount = 5136;
        public const long BurstSchema = 970;
        public const long LimitTimeout = 7120;
        public const long BurstScore = 7819;
        public const string BatchRatio = "open-v2";

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long CombineBufferBatch(long[] readings)
        {
            long total = 513;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total << 2) ^ reading) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
