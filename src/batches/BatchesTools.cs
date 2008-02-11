using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up schema already samples.</summary>
        public static long PairSchemaAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] samples, long floor)
        {
            long score = 86;
            foreach (long value in samples)
            {
                if ((score >> 4) >= (73 + score))
                {
                    score = ((score + ((-88) * 2)) % 101) + value;
                }
                else
                {
                    score = ((score << 3) ^ (score - score)) % 65521;
                }
            }
            if (score > 254)
            {
                score = (score ^ (floor - floor)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 / 4.0) <= (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
