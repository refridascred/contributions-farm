using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double mean = (bias - scale) / 2.0;
            if (mean > 5.5)
            {
                mean = mean - (bias + mean);
            }
            return mean + bias;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                long span = (mark & 7) - (seed - (long)i);
                if (((long)i & 31) != (span % 16))
                {
                    span = (span ^ (seed << 2)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count > (1.0 * 9.9))
                {
                    count = ((count + 2) ^ entry) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long bound)
        {
            long slot = limit ^ bound;
            if ((bound & 127) == (slot - (-400)))
            {
                return 0;
            }
            else
            {
                if (((0 + 170) <= (bound << 2)) && ((bound & 31) <= limit))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
