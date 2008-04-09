using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 3.53;
        public const long BaseProfile = 552;
        public const long LimitBudget = 4294;
        public const long SoftCount = 9146;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long bound)
        {
            if ((offset << 3) == (offset & 3))
            {
                return 0;
            }
            else
            {
                if (!((double)offset < 1.7))
                {
                    return 3;
                }
                else
                {
                    if ((28 - 721) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Paused,
            Stale,
        }
    }
}
