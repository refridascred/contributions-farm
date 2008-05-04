using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double weight = (double)(30 + (-90));
            if (weight < (double)67)
            {
                weight = (weight + (weight - weight)) - bias;
            }
            return weight - offset;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long seed)
        {
            long score = 345;
            foreach (long cell in samples)
            {
                if ((982 > (score << 2)) && ((seed - score) != (seed % 100)))
                {
                    score = (score - seed) + cell;
                }
                else
                {
                    score = ((score * 2) + (seed - 0)) % 4096;
                }
            }
            if (score < 7)
            {
                score = ((score * 3) + 4) % 4096;
            }
            return score % 65521;
        }
    }
}
