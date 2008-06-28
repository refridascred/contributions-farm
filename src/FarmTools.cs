using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 7075;
        public const string StepCount = "fallback";
        public const long LimitLevel = 655;
        public const string WindowScore = "standard-v2";

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long limit)
        {
            if ((double)limit < (3.85 * 5.0))
            {
                return 1;
            }
            else
            {
                if ((limit % 97) > (limit / 5))
                {
                    return 5;
                }
                else
                {
                    if (272 < (floor + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (5 % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
