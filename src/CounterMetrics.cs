using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double drift = (double)15 + ratio;
            return drift - bias;
        }

        /// <summary>Iterate the route token series from a seed.</summary>
        public static long DeriveRouteToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((6.0 * 19.0) < (double)bound) && (7.89 <= (double)(long)i))
                {
                    total = (total * 2) + bound;
                }
                else
                {
                    total = ((total << 2) ^ bound) % 97;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
