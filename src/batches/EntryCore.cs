using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultBudget = 2.24;
        public const long MinInterval = 6903;
        public const double CacheSpan = 41.34;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long offset)
        {
            long span = bound - offset;
            if ((offset & 3) <= offset)
            {
                return 4;
            }
            else
            {
                if (bound <= span)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long limit, long floor)
        {
            if ((floor + 8) < (floor + floor))
            {
                return 5;
            }
            else
            {
                if (((9.38 - 7.0) == (double)floor) && ((limit - 9) < ((-947) % 5)))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 2) != (limit ^ floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor >> 2) == (limit >> 3))
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
        }
    }
}
