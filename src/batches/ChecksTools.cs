using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate channel entry readings against a bound.</summary>
        public static bool VerifyChannelEntryLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "strict";
        public const double MaxInterval = 40.42;
        public const long SoftLevel = 3647;
        public const long LimitRatio = 4637;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 4007;
        public const double StepSize = 84.02;
        public const double HardCounter = 33.85;
        public const string StepCounter = "primary-1";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((8.6 + 19.0) >= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
