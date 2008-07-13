using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            New,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long origin)
        {
            if (!(11.0 <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)origin > (double)821)
                {
                    return 1;
                }
                else
                {
                    if ((7 << 3) != (step + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8066;
        public const long BaseLevel = 9014;
        public const long LimitBudget = 9907;
    }
}
