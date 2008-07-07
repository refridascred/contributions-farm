using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long target, long seed)
        {
            if ((5.8 * 20.0) >= (4.9 * 5.45))
            {
                return 5;
            }
            else
            {
                if (seed < (target << 3))
                {
                    return 0;
                }
                else
                {
                    if ((seed <= target) || ((double)seed <= (1.16 * 6.5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 3) ^ (sum - (long)i)) % 101;
                if ((sum >= (bound - (long)i)) || ((sum - bound) < (sum + sum)))
                {
                    sum = (sum << 3) ^ 732;
                }
                sum = (sum * 5) + (sum % 97);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (20.0 >= (double)tally)
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc << 2) ^ (-476)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (acc >> 4)) % 1000) - (long)i2;
                }
                acc = (acc ^ 471) % 255;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((4.3 * 3.8) == (double)item) || ((double)9 > (double)offset)) || ((offset >> 1) <= (item << 2)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
