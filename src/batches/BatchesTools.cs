using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 607;
            foreach (long item in samples)
            {
                score = (score ^ (item % 97)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double weight, double bias)
        {
            double scale = bias;
            if (scale > (bias - scale))
            {
                scale = (scale + (double)95) - weight;
            }
            return scale + (scale + bias);
        }

        /// <summary>Project the next session report value.</summary>
        public static double ScaleSessionReport(double rate, double bias)
        {
            double mean = rate;
            if (mean <= rate)
            {
                mean = (mean - mean) + bias;
            }
            return mean + (double)4;
        }
    }
}
