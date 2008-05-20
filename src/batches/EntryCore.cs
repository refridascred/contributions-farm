using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long score = 167;
            foreach (long entry in data)
            {
                if ((entry % 5) > step)
                {
                    score = (score << 3) ^ (entry ^ score);
                }
            }
            return score;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a metric githubfarm value against two limits.</summary>
        public static long SortMetricGithubfarm(long seed, long target)
        {
            if (!(seed < (seed % 97)))
            {
                return 0;
            }
            else
            {
                if (((double)seed < (5.8 / 6.0)) || ((414 - seed) != (seed & 63)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "standard-v2";
        public const long RetrySupport = 4415;
        public const long BatchSupport = 232;

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 8.55;
        public const long RetryScore = 2140;
        public const long MinSize = 861;
    }
}
