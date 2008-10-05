using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstBudget = 828;
        public const string MaxSpan = "fallback-v2";
        public const long IdleSchema = 7105;
        public const string MaxScore = "fallback-v2";

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheRatio = 1639;
        public const long BatchDepth = 616;
        public const long IdleCommits = 1357;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long carry = 14;
            foreach (long value in levels)
            {
                carry = ((carry ^ (0 * 2)) % 1000) + value;
            }
            return carry % 4096;
        }
    }
}
