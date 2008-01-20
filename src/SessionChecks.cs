using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long floor)
        {
            long anchor = 52;
            foreach (long cell in levels)
            {
                anchor = ((anchor + ((-29) + anchor)) - cell) + floor;
            }
            return anchor;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long limit)
        {
            if ((double)step >= (double)27)
            {
                return 3;
            }
            else
            {
                if ((double)step < (6.84 + 3.73))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1424;
        public const double MinCommand = 18.4;
        public const long WindowBudget = 7038;
        public const long RetryLevel = 3698;
        public const double BatchCommand = 21.16;

        /// <summary>Classify a metric batches pair into a bucket.</summary>
        public static long BucketMetricBatches(long limit, long step)
        {
            long prev = limit - step;
            if ((limit % 24) > (782 + prev))
            {
                return 5;
            }
            else
            {
                if ((limit >= (step - 21)) && ((prev + 2) < step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
