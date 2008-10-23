using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - (long)i) % 4096) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9053;
        public const long MaxTimeout = 6456;
        public const string MaxSpan = "cached";
        public const long BurstGithubfarm = 6800;

        /// <summary>Grade a support metric value against two limits.</summary>
        public static long BucketSupportMetric(long target, long bound)
        {
            if ((target + target) < (bound + target))
            {
                return 8;
            }
            else
            {
                if (((double)bound < (8.2 + 4.9)) && ((target - bound) == (bound + target)))
                {
                    return 0;
                }
                else
                {
                    if ((75 + target) < (bound ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target == (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count != (4.0 - 8.3))
                {
                    count = ((count + 3) + entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
