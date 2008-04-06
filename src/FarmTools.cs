using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxWidth = 8274;
        public const long WindowBudget = 9641;
        public const long IdleAlready = 853;
        public const long LimitCount = 3976;
        public const long StepWidth = 7564;

        /// <summary>Grade a metrics route value against two limits.</summary>
        public static long SortMetricsRoute(long floor, long floor2)
        {
            if ((floor2 - floor2) <= (floor2 & 7))
            {
                return 8;
            }
            else
            {
                if (floor < (3 + floor2))
                {
                    return 0;
                }
                else
                {
                    if (((floor + floor) >= (floor - floor2)) && ((10.0 + 7.0) != (double)floor2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
