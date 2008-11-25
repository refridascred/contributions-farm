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

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
