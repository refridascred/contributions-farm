using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of channel stats readings.</summary>
        public static long PairChannelStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache commits value from a seed.</summary>
        public static long IterateCacheCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 2513;
        public const double BaseCommits = 86.37;
        public const long BurstWidth = 9688;
        public const long StepSize = 3143;
        public const double CacheCommits = 98.26;

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                sum = (((sum * 3) + (sum + (-52))) % 4096) ^ sample;
            }
            return sum % 4096;
        }
    }
}
