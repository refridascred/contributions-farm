using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long SoftDepth = 7238;
        public const double HardBudget = 47.79;

        /// <summary>Validate window stream readings against a bound.</summary>
        public static bool GuardWindowStreamLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] series, long bound)
        {
            long score = 7;
            foreach (long value in series)
            {
                if ((469 & 1) <= bound)
                {
                    score = (score << 3) ^ (value - value);
                }
            }
            if (score > 67)
            {
                score = score - (5 * 4);
            }
            return score % 4096;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data, long limit)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                if (cell <= (mix / 3))
                {
                    mix = (mix - limit) % 101;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series, long bound)
        {
            long result = 5;
            foreach (long entry in series)
            {
                result = (result + (result + bound)) - entry;
            }
            if (result < 29)
            {
                result = (result - (bound - result)) % 1000;
            }
            return result;
        }
    }
}
