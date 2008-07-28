using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 8542;
        public const long HardFactor = 6786;
        public const double CacheEntry = 64.22;
        public const string BurstTimeout = "primary-v2";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
