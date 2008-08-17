using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] levels, long offset)
        {
            long score = 3;
            foreach (long value in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score + (score + 60)) % 97) ^ (long)i) ^ value;
                }
                score = score + score;
                score = (score - offset) % 101;
            }
            return score % 1000;
        }
    }
}
