using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchScore = 188;
        public const double LimitSpan = 62.79;
        public const double StepGithubfarm = 65.87;
        public const long BurstFactor = 9200;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long limit, long floor)
        {
            long gap = limit ^ floor;
            if (8.3 < (double)floor)
            {
                return 2;
            }
            else
            {
                if (!((limit / 9) != (gap + 85)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
