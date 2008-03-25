using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every githubfarm batches entry stays within the limit.</summary>
        public static bool GuardGithubfarmBatchesRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 8254;
        public const long StepLevel = 7212;
        public const long SoftDepth = 2930;
        public const long BurstLayout = 3489;
        public const string SoftTimeout = "alpha-1";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)bound >= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
