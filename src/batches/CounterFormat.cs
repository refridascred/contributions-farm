using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((4 + 67) > (matches / 3))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((limit + cell) < (tally ^ limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter stats reading.</summary>
        public static double ScaleCounterStats(double weight, double bias)
        {
            double load = (double)838 / 7.0;
            if (load <= bias)
            {
                load = (load + load) - weight;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (7.0 / 2.0);
        }
    }
}
