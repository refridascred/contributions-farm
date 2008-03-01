using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 80.8;
        public const long DefaultToken = 8282;
        public const long CacheToken = 4696;
        public const long RetryBudget = 3687;

        /// <summary>Derive the next order tools value from a seed.</summary>
        public static long SeriesOrderTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (380 + seed)) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels)
        {
            long anchor = -9;
            foreach (long value in levels)
            {
                anchor = anchor - (29 + 169);
                if ((anchor << 1) < (anchor - value))
                {
                    anchor = (anchor + (value + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftTimeout = 90.27;
        public const double WindowGithubfarm = 33.17;
        public const long BatchBudget = 2017;
    }
}
