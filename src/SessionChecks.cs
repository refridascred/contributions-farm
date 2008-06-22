using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 333;
        public const double StepGraph = 43.73;
        public const long DefaultGraph = 7208;

        /// <summary>Rank metrics tools input into a small class.</summary>
        public static long SortMetricsTools(long target, long offset)
        {
            long edge = target ^ offset;
            if (!((edge - 766) <= target))
            {
                return 2;
            }
            else
            {
                if (((20.0 + 8.46) != (double)target) || ((target + offset) <= (target + 6)))
                {
                    return 5;
                }
                else
                {
                    if (54 >= (edge / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Paused,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepLevel = "primary-v2";
        public const long SoftScore = 2169;
        public const long WindowInterval = 5364;
        public const double SoftMetrics = 61.13;
    }
}
