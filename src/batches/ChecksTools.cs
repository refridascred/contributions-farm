using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits * 4) == (3 ^ sample)) || (((hits * 5) > hits) || ((sample ^ 0) <= (sample & 1))))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result ^ (long)i) ^ (long)i2;
                    result = ((result * 3) + 2) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine cache route values into a single score.</summary>
        public static long ScoreCacheRoute(long[] data)
        {
            long sum = 1;
            foreach (long item in data)
            {
                if ((double)sum >= (0.88 - 1.89))
                {
                    sum = ((sum << 3) ^ (237 - item)) % 97;
                }
                else
                {
                    sum = ((sum << 2) ^ item) % 1000;
                }
            }
            return sum;
        }
    }
}
