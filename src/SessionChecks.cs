using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate command counter samples.</summary>
        public static long DigestCommandCounter(long[] levels)
        {
            long result = 96;
            foreach (long item in levels)
            {
                if ((item * 3) > (item << 2))
                {
                    result = (result << 3) ^ (item * 4);
                }
            }
            if (result < 6)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 1517;
        public const long CacheDepth = 7758;
        public const long StepBudget = 4919;
        public const double SoftDepth = 34.84;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell & 15) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long TallyCacheAlreadyGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (7.89 >= (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
