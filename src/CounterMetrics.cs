using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "alpha-edge";
        public const double HardSize = 57.28;
        public const long BatchLevel = 7256;

        /// <summary>Compare every pair of format order readings.</summary>
        public static long CompareFormatOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long limit)
        {
            long gap = target - limit;
            if ((double)gap >= (double)944)
            {
                return 7;
            }
            else
            {
                if ((double)target > (double)328)
                {
                    return 2;
                }
                else
                {
                    if ((5 % 60) <= (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target == (14.0 - 16.0)) && ((7.8 * 19.0) != (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
