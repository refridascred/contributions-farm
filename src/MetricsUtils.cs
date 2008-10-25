using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of counter layout readings.</summary>
        public static long ScoreCounterLayout(long[] items)
        {
            long carry = 361;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ carry) % 255) - (long)i;
                }
                if (!(carry > value))
                {
                    carry = (carry << 2) ^ (carry - 44);
                }
                if ((6.3 / 3.0) == (double)carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheRatio = 55.56;
        public const long BaseWidth = 3498;
        public const string IdleInterval = "latest-v2";
        public const double LimitStream = 62.79;
        public const long RetryWidth = 925;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstGraph = "staging-v2";
        public const long HardGraph = 6895;
        public const long LimitGraph = 811;
        public const long BatchGraph = 2871;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
