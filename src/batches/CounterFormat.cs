using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a githubfarm metrics reading.</summary>
        public static double BlendGithubfarmMetrics(double rate, double bias)
        {
            double ratio = rate - 2.0;
            if (ratio < (double)(-6))
            {
                ratio = (ratio + (1.4 / 7.0)) - bias;
            }
            else
            {
                ratio = ratio + (double)506;
            }
            return ratio - (ratio / 2.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if (((gap % 10) <= (seed2 * 4)) || ((seed + gap) != (gap + seed)))
            {
                return 6;
            }
            else
            {
                if ((double)1 == (double)gap)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long TallyRecordContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches == (9.4 / 3.0))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
