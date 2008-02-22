using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchRatio = 7532;
        public const long RetryCount = 1402;
        public const double BurstLevel = 97.39;
        public const long MaxSpan = 3420;
        public const long MaxLevel = 452;

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5758;
        public const long BurstMetric = 4810;
        public const long CacheMetric = 9191;
        public const double CacheBudget = 84.11;
        public const string BatchBudget = "primary-v2";

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long mix = 19;
            foreach (long reading in data)
            {
                if (!((mix + 3) >= (reading / 8)))
                {
                    mix = ((mix << 2) ^ (56 + reading)) % 65521;
                    mix = (mix << 2) ^ reading;
                }
                mix = (mix - (mix * 5)) % 97;
                if ((double)mix < 5.8)
                {
                    mix = ((mix << 3) ^ (reading << 2)) % 1000;
                }
                if (72 > (mix + 0))
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
