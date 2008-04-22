using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long SortProfileBuffer(long floor, long bound)
        {
            long slot = floor + bound;
            if (!((slot % 10) == (bound * 3)))
            {
                return 8;
            }
            else
            {
                if (slot < 80)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 8789;
        public const double DefaultFactor = 50.64;
        public const long MinFormat = 4495;

        /// <summary>Validate cache editor readings against a bound.</summary>
        public static bool ValidateCacheEditorRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
