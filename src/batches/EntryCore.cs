using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxRatio = "standard-v2";
        public const string WindowLayout = "strict";
        public const double IdleLayout = 4.88;
        public const long RetrySpan = 3342;
        public const string SoftLayout = "stable-1";

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Size { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a order route pair into a bucket.</summary>
        public static long RankOrderRoute(long seed, long seed2)
        {
            long lane = seed + seed2;
            if ((414 / 2) >= lane)
            {
                return 2;
            }
            else
            {
                if (((lane / 8) <= (seed + lane)) && ((701 >> 3) != (seed2 / 6)))
                {
                    return 1;
                }
                else
                {
                    if (lane >= 52)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((84 + seed2) <= (lane - seed2)) && ((seed2 + seed2) <= (lane & 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseBatch = "stable-1";
        public const long CacheRatio = 5001;
        public const double WindowTimeout = 62.35;
    }
}
