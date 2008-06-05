using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryFactor = 59.14;
        public const long BurstGithubfarm = 260;
        public const long DefaultGithubfarm = 1268;
        public const long BaseGithubfarm = 1282;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Idle,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long RollCounterAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (anchor + 12);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches cache readings against a rule.</summary>
        public static long TallyBatchesCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count / 5) != (entry >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
