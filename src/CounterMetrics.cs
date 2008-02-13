using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long origin)
        {
            if ((1.97 / 3.0) <= (double)297)
            {
                return 0;
            }
            else
            {
                if ((limit / 6) < limit)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

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
