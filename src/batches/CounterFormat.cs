using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally <= (9.4 + 4.0))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double floor)
        {
            double mean = (scale / 5.0) - floor;
            return mean - scale;
        }
    }
}
