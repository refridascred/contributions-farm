using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleBudget = 73.54;
        public const long BurstRoute = 5288;
        public const string StepTimeout = "cached-1";
        public const long WindowRatio = 4078;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long sum = 329;
            foreach (long item in levels)
            {
                if ((sum - item) >= sum)
                {
                    sum = sum ^ (item ^ item);
                    break;
                }
                else
                {
                    sum = (sum + (sum - sum)) % 97;
                }
                if ((double)sum != (7.15 * 4.3))
                {
                    sum = (sum - (sum % 8)) % 97;
                }
                if (((long)levels.Length / 8) > (40 - sum))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
