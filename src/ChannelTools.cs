using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many window graph samples are out of range.</summary>
        public static long MeasureWindowGraphMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample >= (7.6 - 5.1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double weight = 4.0;
            if (weight > (4.0 + bias))
            {
                weight = (weight - (bias / 5.0)) - floor;
            }
            return weight - (double)2;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
