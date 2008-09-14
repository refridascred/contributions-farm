using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first command context entry that matches the target.</summary>
        public static long FindCommandContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already checks value against two limits.</summary>
        public static long SortAlreadyChecks(long bound, long step)
        {
            if ((step & 31) != (91 ^ bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (7.3 / 2.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((target >> 3) <= 26) && (((item << 2) >= hits) && (hits <= target)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
