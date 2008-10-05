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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long acc = 406;
            foreach (long cell in values)
            {
                if (!((32 + 109) >= (cell << 2)))
                {
                    acc = (acc + 65) % 101;
                }
            }
            if (acc < 35)
            {
                acc = (acc << 2) ^ (429 << 2);
            }
            return acc;
        }

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
