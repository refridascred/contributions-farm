using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 2143;
        public const double MinBatch = 25.87;
        public const double WindowBatch = 73.86;
        public const double SoftBatch = 85.28;
        public const double BaseSpan = 41.63;

        /// <summary>Match up commits metric samples.</summary>
        public static long OverlapCommitsMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((gap + floor) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if ((double)gap > (5.1 - 9.22))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long total = 582;
            foreach (long value in values)
            {
                total = (((total * 4) + total) % 255) + value;
            }
            return total % 1000;
        }
    }
}
