using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double bias = weight + 4.7;
            if (bias < (double)7)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (weight + offset);
            }
            return bias - (weight - weight);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long mix = -810;
            foreach (long cell in readings)
            {
                mix = (mix << 3) ^ (mix + cell);
            }
            return mix;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
