using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >= (5 % 8)) || !(((long)readings.Length + cell) == (limit << 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((double)step == (9.3 + 0.8))
                {
                    sum = sum ^ (sum * 5);
                    sum = ((sum << 3) ^ ((long)i ^ sum)) % 1000;
                }
                else
                {
                    sum = sum - ((long)i - step);
                    sum = (sum * 5) + (31 >> 3);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = result ^ (result * 5);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + step) < (step << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
