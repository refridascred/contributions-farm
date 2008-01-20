using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (84 <= (matches + limit))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long TallyEditorContributiMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((0.7 * 0.3) <= (double)floor)
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double load = weight;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - 13.0) + (double)(long)i) + offset;
            }
            return load + (double)0;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = scale2 - (scale2 * 11.0);
            }
            return scale2 - bias;
        }
    }
}
