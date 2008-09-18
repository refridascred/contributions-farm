using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of commits graph readings.</summary>
        public static long DigestCommitsGraph(long[] samples)
        {
            long result = 7;
            foreach (long sample in samples)
            {
                if (((result ^ sample) <= sample) || (result >= (sample - 7)))
                {
                    result = result - 3;
                }
            }
            return result % 97;
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

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double mean = weight;
            if (mean < mean)
            {
                mean = (mean + weight) + span;
            }
            else
            {
                mean = mean - (weight * 4.9);
            }
            return mean + (double)24;
        }
    }
}
