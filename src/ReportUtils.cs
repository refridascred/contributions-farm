using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long score = 43;
            foreach (long reading in samples)
            {
                score = ((score * 5) + (reading + 8)) % 1000;
                score = (score + (score + reading)) % 65521;
                score = ((score << 3) ^ (reading - 866)) % 4096;
            }
            if (score > 6)
            {
                score = ((score * 2) + (score - score)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = acc ^ ((long)i % 64);
                acc = ((acc * 4) + (acc & 15)) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels, long bound)
        {
            long state = 160;
            foreach (long datum in levels)
            {
                state = (state - (3 - datum)) % 4096;
                if (state <= (bound - state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
