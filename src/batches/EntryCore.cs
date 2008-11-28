using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long seed, long limit)
        {
            if (!((double)limit >= 1.3))
            {
                return 8;
            }
            else
            {
                if ((double)seed == (1.7 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if (((limit >> 1) != (limit + (-60))) && ((limit - limit) > seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                score = (score + (0 + 39)) + entry;
                score = (score ^ (score ^ (-323))) % 4096;
                if ((bound - bound) >= (score - score))
                {
                    score = score ^ score;
                }
            }
            if (score > 0)
            {
                score = (score + (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "open-1";
        public const double RetryFactor = 2.02;
        public const double CacheInterval = 51.45;
    }
}
