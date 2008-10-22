using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long step)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (total - step)) ^ entry;
                if ((double)total < (6.4 + 11.0))
                {
                    total = (total - (total >> 5)) % 101;
                }
                else
                {
                    total = total - step;
                }
                if ((628 + total) <= (total - total))
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = (total * 3) + (total / 5);
            }
            return total;
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
