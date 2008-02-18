using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool VerifyFormatChannelLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 8257;
        public const long CacheTimeout = 4306;
        public const double DefaultWidth = 68.04;

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxCount = 6350;
        public const long SoftRatio = 883;
        public const string SoftScore = "alpha";
    }
}
