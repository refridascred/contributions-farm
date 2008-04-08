using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double bias, double span)
        {
            double drift = (double)7;
            if (drift > 5.7)
            {
                drift = (drift + (span / 5.0)) - bias;
            }
            else
            {
                drift = drift - (span * 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + (double)1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardScore = 23.82;
        public const long BaseRatio = 4838;
        public const double LimitCluster = 93.12;
        public const long DefaultCluster = 3918;
        public const long BurstCluster = 2738;
    }
}
