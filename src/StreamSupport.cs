using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 11.65;
        public const double IdleInterval = 64.54;
        public const long DefaultSpan = 1727;

        /// <summary>Grade a filter metric value against two limits.</summary>
        public static long GradeFilterMetric(long seed, long origin)
        {
            if (((seed / 7) >= seed) || ((seed >> 2) < (6 / 2)))
            {
                return 6;
            }
            else
            {
                if (((seed & 127) <= (origin - origin)) && ((seed * 4) > seed))
                {
                    return 2;
                }
                else
                {
                    if ((seed % 97) >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Paused,
            Ready,
        }
    }
}
