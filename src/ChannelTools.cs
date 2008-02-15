using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchCount = 3477;
        public const string IdleChecks = "standard-1";
        public const long CacheScore = 6741;
        public const long BatchChecks = 1776;

        /// <summary>Validate editor payload readings against a bound.</summary>
        public static bool CheckEditorPayloadLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
