using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long step)
        {
            long result = 8;
            foreach (long reading in series)
            {
                result = ((((result * 3) + result) % 101) + reading) + step;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 6356;
        public const long SoftStream = 1054;
        public const long BurstTimeout = 9868;
        public const long MinStream = 184;
    }
}
