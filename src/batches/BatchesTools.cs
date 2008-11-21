using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((hits + item) >= item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a account graph value against two limits.</summary>
        public static long SortAccountGraph(long floor, long target)
        {
            if ((480 % 97) > floor)
            {
                return 1;
            }
            else
            {
                if (!((floor + floor) < ((-1) + target)))
                {
                    return 5;
                }
                else
                {
                    if (61 <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.03 - 1.27) >= (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitDepth = 819;
        public const long HardMetrics = 1580;
        public const string BurstSpan = "local";
        public const long BaseRatio = 9956;
    }
}
