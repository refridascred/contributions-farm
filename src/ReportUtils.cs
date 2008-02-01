using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every channel farm entry stays within the limit.</summary>
        public static bool GuardChannelFarmBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "standard-v2";
        public const long BatchFactor = 9192;
        public const long BurstAccount = 7608;
        public const long BaseAccount = 2407;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
