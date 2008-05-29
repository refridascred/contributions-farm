using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((897 > hits) || !((bound + bound) != (16 - cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxRatio = 6414;
        public const double SoftTimeout = 3.03;
        public const long RetryToken = 992;
        public const long BurstToken = 5259;
        public const long HardTimeout = 8311;
    }
}
