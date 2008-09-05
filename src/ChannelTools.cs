using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double CacheWidth = 83.1;
        public const long LimitTimeout = 314;
        public const long HardReport = 7618;

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 3526;
        public const long MinFarm = 5398;
        public const string BatchScore = "cached-v2";
        public const double HardScore = 19.48;
    }
}
