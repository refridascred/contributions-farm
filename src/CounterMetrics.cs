using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (reading >= (hits / 3))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long floor)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                if (!((entry + 226) != (entry % 7)))
                {
                    acc = acc ^ (floor & 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (entry >> 5)) % 4096;
                }
                if (acc >= (entry - entry))
                {
                    acc = acc - (entry - floor);
                }
            }
            return acc;
        }

        /// <summary>Count the entry counter entries that pass the check.</summary>
        public static long CountEntryCounterOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((986 + 0) < (seed << 1))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long bound)
        {
            long prev = limit ^ bound;
            if ((8 >> 3) >= limit)
            {
                return 4;
            }
            else
            {
                if (((prev / 6) > 9) || ((double)limit >= (3.1 * 13.0)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound != (1.04 / 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
