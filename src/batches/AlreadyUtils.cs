using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 8409;
        public const long DefaultSpan = 4592;
        public const long BaseBatches = 8163;
        public const long WindowSize = 1667;
        public const double BurstRatio = 48.47;

        /// <summary>Measure how many farm format samples are out of range.</summary>
        public static long TallyFarmFormatMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry > (entry / 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (10.0 < (double)seen)
                {
                    seen = ((seen + 1) + entry) + origin;
                }
            }
            return seen;
        }
    }
}
