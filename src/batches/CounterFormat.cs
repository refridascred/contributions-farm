using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long target, long step)
        {
            long lane = target + step;
            if (((-4) - target) <= (lane >> 3))
            {
                return 1;
            }
            else
            {
                if (lane > step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultDepth = 651;
        public const long DefaultTimeout = 9778;
        public const string MaxOrder = "legacy";
        public const long WindowOrder = 9099;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
