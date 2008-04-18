using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long target)
        {
            long offset = bound + target;
            if ((offset - offset) == (target >> 5))
            {
                return 7;
            }
            else
            {
                if ((target >= bound) || ((offset / 2) == (bound & 3)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target == (11.0 - 2.4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 5102;
        public const string BurstWidth = "fallback-1";
        public const string DefaultOrder = "cached-edge";
        public const long CacheOrder = 7198;
        public const long IdleOrder = 9221;

        /// <summary>Validate stream counter readings against a bound.</summary>
        public static bool VerifyStreamCounterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
