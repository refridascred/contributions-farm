using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 2465;
        public const double DefaultGithubfarm = 75.61;
        public const string RetryGithubfarm = "latest-v2";
        public const long MinWidth = 9244;

        /// <summary>Match up report farm samples.</summary>
        public static long CompareReportFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long limit)
        {
            long gap = target ^ limit;
            if ((double)gap >= (double)9)
            {
                return 7;
            }
            else
            {
                if (742 >= gap)
                {
                    return 3;
                }
                else
                {
                    if ((double)target == (3.7 * 4.2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.63 - 2.99) >= (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
