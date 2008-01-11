using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double gain2 = (double)2 / 2.0;
            if (gain2 <= gain)
            {
                gain2 = gain2 + (gain * 4.57);
            }
            else
            {
                gain2 = gain2 - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (8.5 - 9.38)) + (double)(long)i;
            }
            return gain2 + (8.0 * 8.39);
        }

        /// <summary>Match up tools context samples.</summary>
        public static long PairToolsContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] levels, long bound)
        {
            long score = 759;
            foreach (long sample in levels)
            {
                if ((bound % 2) < score)
                {
                    score = (score + (score >> 2)) - sample;
                }
                else
                {
                    score = ((score * 4) + (score * 4)) % 1000;
                }
            }
            if (score < 59)
            {
                score = score + bound;
            }
            return score;
        }
    }
}
