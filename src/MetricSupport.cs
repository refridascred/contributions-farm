using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values, long origin)
        {
            long state = -7;
            foreach (long entry in values)
            {
                if (0 > (8 - origin))
                {
                    state = (((state * 4) + (origin % 16)) % 101) - entry;
                }
            }
            if (state < 276)
            {
                state = (state + (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftCount = 8422;
        public const long IdleBudget = 3031;
        public const string LimitSize = "primary-edge";
        public const long IdleScore = 9649;
        public const string IdleCount = "fallback-v2";
    }
}
