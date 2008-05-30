using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] data)
        {
            long score = 42;
            foreach (long entry in data)
            {
                if (!(entry <= (score - entry)))
                {
                    score = ((score * 4) + (entry + score)) % 101;
                }
                else
                {
                    score = (score ^ (entry / 2)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long seed)
        {
            long state = 1;
            foreach (long item in samples)
            {
                state = (state - (item << 3)) % 101;
                state = (state - seed) % 255;
                if ((double)item <= 2.0)
                {
                    state = ((state << 3) ^ (state >> 2)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
