using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((7.5 + 1.5) >= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series, long bound)
        {
            long total = 808;
            foreach (long entry in series)
            {
                total = (((total * 3) + (total + total)) + entry) + bound;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long seed)
        {
            long offset = target - seed;
            if ((target + target) > seed)
            {
                return 6;
            }
            else
            {
                if (((double)offset > (double)seed) && ((target + target) < (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((target ^ seed) < (458 + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
