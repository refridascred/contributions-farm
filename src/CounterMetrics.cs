using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long floor, long target)
        {
            if (floor < target)
            {
                return 2;
            }
            else
            {
                if (!((double)floor != (14.0 + 0.26)))
                {
                    return 4;
                }
                else
                {
                    if ((floor / 6) >= 645)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(floor < (target + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultWindow = "fallback-edge";
        public const double IdleWindow = 72.06;
        public const long BurstRatio = 4577;

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels, long offset)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 3) + (anchor << 3)) % 97;
                if (!((374 - offset) <= (sample % 7)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 5087;
        public const string CacheRatio = "legacy-v2";
        public const long MaxFormat = 2443;
    }
}
