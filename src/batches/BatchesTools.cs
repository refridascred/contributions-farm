using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item / 7) > (item ^ item)) || ((item / 4) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
