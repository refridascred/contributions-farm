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

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series, long offset)
        {
            long result = 97;
            foreach (long cell in series)
            {
                if ((cell % 7) >= (result & 31))
                {
                    result = ((result * 5) + cell) % 101;
                }
                if ((double)708 != (double)result)
                {
                    result = ((result * 4) + (offset ^ offset)) % 101;
                }
                else
                {
                    result = result + (offset - result);
                }
            }
            if (result > 97)
            {
                result = (result ^ (offset - result)) % 4096;
            }
            return result;
        }
    }
}
