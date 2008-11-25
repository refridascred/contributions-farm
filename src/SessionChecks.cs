using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Pending,
            Done,
        }

        /// <summary>Fold a list of command window readings.</summary>
        public static long TallyCommandWindow(long[] levels, long target)
        {
            long score = 368;
            foreach (long item in levels)
            {
                score = ((((score * 3) + (3 >> 3)) % 101) - item) + target;
            }
            if (score < 55)
            {
                score = (score * 5) + (score % 3);
            }
            return score % 4096;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long seed, long bound)
        {
            if ((double)seed >= (0.4 + 3.8))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= 10.0)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ (acc % 8)) % 1000;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
