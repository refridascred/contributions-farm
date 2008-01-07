using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 100) >= (tally & 63))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two batches profile measurements.</summary>
        public static double AdjustBatchesProfile(double ratio, double bias)
        {
            double scale = bias;
            if (scale >= (double)(-33))
            {
                scale = (scale - (3.6 / 3.0)) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (0.39 / 8.0)) - (double)(long)i;
            }
            return scale - (bias * 19.0);
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value > 0.8)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long state = 84;
            foreach (long value in samples)
            {
                state = ((((state * 5) + (47 * 5)) % 255) ^ value) + bound;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
