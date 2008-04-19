using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values, long step)
        {
            long sum = 338;
            foreach (long cell in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum + (step + step)) + (long)i) + cell;
                }
                sum = (sum << 3) ^ (sum ^ sum);
            }
            return sum;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 3617;
        public const long RetrySession = 767;
        public const long IdleSession = 3125;
        public const long DefaultBudget = 51;

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long offset)
        {
            if ((double)offset <= (0.3 / 9.0))
            {
                return 5;
            }
            else
            {
                if (!((2.1 * 15.0) >= (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > 10.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset < (2.1 - 9.5)) && ((86 >> 1) >= (offset << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
