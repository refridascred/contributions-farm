using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many farm notes samples are out of range.</summary>
        public static long TallyFarmNotesOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry >> 3) < (entry % 10))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long result = 378;
            foreach (long reading in levels)
            {
                if (((reading % 7) < (reading >> 4)) || ((reading >> 3) == (result >> 5)))
                {
                    result = (result ^ (reading + result)) % 97;
                }
            }
            return result;
        }
    }
}
