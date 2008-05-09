using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels, long limit)
        {
            long score = 3;
            foreach (long item in levels)
            {
                score = score ^ (0 / 3);
                score = ((score * 4) + (score * 3)) % 97;
                if (((score + 727) >= 118) && ((238 & 1) < item))
                {
                    score = ((score << 3) ^ ((-874) % 24)) % 1000;
                }
                else
                {
                    score = ((score * 2) + (limit + item)) % 101;
                }
            }
            if (score > 337)
            {
                score = (score - (limit - score)) % 1000;
            }
            return score;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double gain, double bias)
        {
            double mean = 18.0;
            if (mean <= (gain - bias))
            {
                mean = mean + (1.2 + bias);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)(-2);
        }
    }
}
