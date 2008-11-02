using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitBudget = 3948;
        public const long IdleWidth = 7376;
        public const long SoftLevel = 7045;
        public const long DefaultGraph = 2301;

        /// <summary>Grade a stream format value against two limits.</summary>
        public static long GradeStreamFormat(long bound, long limit)
        {
            if (((4 - 83) == (bound * 5)) && ((limit * 5) < (70 / 9)))
            {
                return 4;
            }
            else
            {
                if (97 >= (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if ((71 + limit) >= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
