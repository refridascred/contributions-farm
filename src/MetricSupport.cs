using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9776;
        public const long SoftSize = 1496;
        public const long BurstWindow = 810;
        public const string StepWindow = "staging-1";
        public const long SoftBudget = 8869;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long bound)
        {
            if ((limit + bound) <= limit)
            {
                return 4;
            }
            else
            {
                if (!(((-6) * 3) == (limit & 63)))
                {
                    return 5;
                }
                else
                {
                    if (((bound / 5) != (limit - 541)) && (limit >= (bound + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + 98) == (bound >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] items)
        {
            long result = 33;
            foreach (long item in items)
            {
                if ((double)item >= (3.1 - 2.2))
                {
                    result = (result * 3) + item;
                }
                if ((double)result <= (0.57 + 8.1))
                {
                    break;
                }
            }
            return result;
        }
    }
}
