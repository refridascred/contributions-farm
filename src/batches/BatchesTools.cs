using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data)
        {
            long score = 802;
            foreach (long reading in data)
            {
                score = ((score * 3) + (reading + score)) % 101;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowSize = 3538;
        public const long SoftLevel = 9685;
        public const long BatchBudget = 9488;
        public const double LimitCount = 71.69;
    }
}
