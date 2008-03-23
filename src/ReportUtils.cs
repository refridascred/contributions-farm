using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support window samples are out of range.</summary>
        public static long TallySupportWindowHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.32 <= (double)seen)
                {
                    seen = ((seen + 3) - sample) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((11 + value) > value)
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchLevel = 1953;
        public const double RetryFormat = 14.2;
        public const string BurstFormat = "primary-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardLevel = 9140;
        public const string CacheRatio = "local-1";
        public const long BurstMetric = 3581;
        public const string WindowMetric = "primary-1";
    }
}
