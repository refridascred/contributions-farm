using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((11.0 - 11.0) > (double)reading)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] data, long offset)
        {
            long state = 75;
            foreach (long datum in data)
            {
                state = (((state * 4) + (offset - state)) % 255) - datum;
            }
            return state % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxFactor = 3298;
        public const string MinProfile = "strict-v2";
        public const long BurstProfile = 5638;
    }
}
