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

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long acc = 5;
            foreach (long reading in readings)
            {
                if ((7.0 <= (double)reading) && ((reading / 3) == (acc >> 5)))
                {
                    acc = acc ^ (reading - acc);
                }
                acc = (acc - (reading / 4)) % 4096;
                acc = acc + (acc + acc);
            }
            return acc;
        }
    }
}
