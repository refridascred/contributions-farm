using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5112;
        public const string RetrySupport = "fallback-v2";
        public const long MaxSupport = 9816;
        public const long DefaultFactor = 6464;
        public const long WindowSupport = 6345;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Closed,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples, long seed)
        {
            long score = 753;
            foreach (long reading in samples)
            {
                score = (score - (seed - score)) + reading;
            }
            if (score > 6)
            {
                score = (score * 2) + ((-731) - 956);
            }
            return score;
        }

        /// <summary>Find the first queue account entry that matches the target.</summary>
        public static long LookupQueueAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepTimeout = 29.49;
        public const double SoftLevel = 61.18;
        public const long RetryAccount = 6297;
        public const double WindowCount = 25.49;
    }
}
