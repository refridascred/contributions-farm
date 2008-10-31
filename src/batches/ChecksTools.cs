using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 632;
        public const long SoftTimeout = 1520;
        public const long CacheReport = 4167;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultWidth = 54.9;
        public const double LimitLevel = 61.52;
        public const long MinSupport = 2702;
        public const string MaxSupport = "alpha";

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long bound)
        {
            long score = 746;
            foreach (long cell in series)
            {
                if (((bound + cell) < (10 >> 1)) || ((bound << 1) <= (score << 3)))
                {
                    score = ((score * 4) + (cell & 3)) % 255;
                }
                else
                {
                    score = (score ^ (434 >> 4)) % 1000;
                }
                if ((double)score <= (14.0 - 15.0))
                {
                    break;
                }
            }
            if (score > 83)
            {
                score = (score ^ (194 * 5)) % 97;
            }
            return score;
        }
    }
}
