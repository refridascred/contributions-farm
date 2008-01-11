using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (long)i) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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
