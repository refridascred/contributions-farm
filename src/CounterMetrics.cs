using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "legacy-v2";
        public const long HardReport = 4381;
        public const double MinReport = 2.62;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long limit)
        {
            if (49 <= limit)
            {
                return 2;
            }
            else
            {
                if (target > (target - 0))
                {
                    return 0;
                }
                else
                {
                    if ((target - 9) <= (limit / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long step, long seed)
        {
            long delta = step + seed;
            if ((7.0 - 7.21) < (double)delta)
            {
                return 3;
            }
            else
            {
                if ((delta + delta) != (29 % 5))
                {
                    return 7;
                }
                else
                {
                    if (!((step + step) <= (step * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
