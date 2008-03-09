using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((step + tally) >= (8 - item)) || ((tally + tally) >= (item & 3))) && !((double)item <= (17.0 + 0.8)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                if (((547 + seed) != (result ^ result)) || ((76 ^ result) > (seed & 255)))
                {
                    result = (result - ((long)i >> 1)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (-22)) % 255;
                    result = (result ^ ((long)i % 2)) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the cache farm series from a seed.</summary>
        public static long IterateCacheFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 3) ^ (floor + mix)) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long CountStatsLayoutOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits > (12.0 / 7.0))
                {
                    hits = ((hits + 3) - sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
