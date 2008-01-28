using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "alpha-1";
        public const long BurstInterval = 7935;
        public const string IdleGithubfarm = "primary";
        public const long DefaultTimeout = 4357;
        public const double BatchBudget = 24.84;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stream metric samples.</summary>
        public static long TotalStreamMetric(long[] readings)
        {
            long mix = 44;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (long)i) % 97;
                }
                if ((double)value >= (3.03 - 5.56))
                {
                    mix = mix ^ (mix % 64);
                }
            }
            return mix;
        }
    }
}
