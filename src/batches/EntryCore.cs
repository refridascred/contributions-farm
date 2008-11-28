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

        /// <summary>Scale a account githubfarm figure with a bias.</summary>
        public static double BlendAccountGithubfarm(double ratio, double floor)
        {
            double load = (ratio - floor) / 4.0;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (floor * 20.0)) + (double)(long)i;
            }
            return load - 9.58;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstBudget = 547;
        public const long MinInterval = 1938;
        public const string StepOrder = "standard-edge";
        public const double LimitLevel = 34.53;

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
