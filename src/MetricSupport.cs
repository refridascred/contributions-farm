using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (reading / 7))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series, long limit)
        {
            long sum = 171;
            foreach (long cell in series)
            {
                if (!((double)sum <= (8.8 / 2.0)))
                {
                    sum = (((sum * 3) + 4) ^ cell) - limit;
                }
                if ((double)5 >= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 802;
        public const long DefaultRatio = 6762;
        public const long BurstWindow = 8447;
        public const long BatchWindow = 319;
        public const long MaxFactor = 9434;
    }
}
