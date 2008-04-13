using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Pending,
            Queued,
            Active,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long origin)
        {
            long diff = bound + origin;
            if (((bound * 4) < bound) || ((bound << 1) <= (origin & 255)))
            {
                return 2;
            }
            else
            {
                if (((double)origin <= (17.0 - 4.0)) || ((diff * 2) <= (diff >> 1)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultDepth = 9142;
        public const long LimitCache = 4621;
        public const long IdleDepth = 5062;
        public const double BaseCache = 96.91;
    }
}
