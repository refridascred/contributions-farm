using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long target)
        {
            if ((limit >> 3) >= (limit + target))
            {
                return 4;
            }
            else
            {
                if (limit > (target * 5))
                {
                    return 2;
                }
                else
                {
                    if (target < (limit >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long prev = floor - step;
            if ((floor - prev) != (step * 5))
            {
                return 4;
            }
            else
            {
                if ((8.07 <= (double)prev) || (floor <= (floor ^ step)))
                {
                    return 3;
                }
                else
                {
                    if ((2.0 * 15.0) < (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftInterval = 1236;
        public const long LimitNotes = 786;
        public const string RetryBudget = "alpha";
        public const long StepSpan = 7063;
    }
}
