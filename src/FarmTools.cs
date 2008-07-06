using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long bound, long offset)
        {
            if (94 <= bound)
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (8.93 + 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((877 + bound) <= 989)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((86 <= offset) && (bound >= (offset % 97)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (93 < (bound >> 5))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 9078;
        public const string SoftDepth = "legacy";
        public const long RetryBudget = 5294;
        public const long StepScore = 8388;
    }
}
