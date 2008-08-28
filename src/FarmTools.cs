using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            long delta = bound - limit;
            if ((delta << 3) >= (delta - delta))
            {
                return 4;
            }
            else
            {
                if ((6 - limit) >= 3)
                {
                    return 8;
                }
                else
                {
                    if ((delta + bound) < (87 + delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 6) > (bound * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 3) ^ ((long)i >> 3);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples, long offset)
        {
            long sum = -9;
            foreach (long reading in samples)
            {
                sum = sum ^ (reading % 64);
                sum = ((sum << 2) ^ offset) % 101;
                sum = sum - (646 ^ 241);
            }
            return sum;
        }
    }
}
