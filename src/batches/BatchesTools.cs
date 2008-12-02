using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format commits value.</summary>
        public static double ScaleFormatCommits(double bias, double span)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - span;
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a cache counter counter forward.</summary>
        public static long StepCacheCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((score + (long)i) == (limit >> 3)))
                {
                    score = ((score << 2) ^ (score & 127)) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
