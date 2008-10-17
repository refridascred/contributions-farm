using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleTimeout = 1775;
        public const string DefaultTimeout = "standard";
        public const long BaseBatch = 5623;
        public const long LimitBatch = 2962;
        public const string MinDepth = "alpha";

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series)
        {
            long sum = 502;
            foreach (long cell in series)
            {
                sum = (sum * 5) + (176 * 5);
                sum = ((sum << 3) ^ cell) % 255;
                if ((cell + 50) != (sum + sum))
                {
                    sum = ((sum << 2) ^ (cell + cell)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long score = floor;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (90 & 3)) % 1000;
                score = ((score << 2) ^ (score + floor)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 621;
        public const string BaseStats = "latest-v2";
        public const string RetryStats = "open-1";
        public const double BurstSize = 9.26;
    }
}
