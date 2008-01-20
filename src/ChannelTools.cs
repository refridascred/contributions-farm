using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every filter format entry stays within the limit.</summary>
        public static bool GuardFilterFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCount = 2863;
        public const long SoftFactor = 4319;
        public const long BatchCounter = 801;
        public const long BatchBudget = 6881;
    }
}
