using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 23.49;
        public const long BaseDepth = 9501;
        public const long DefaultCount = 824;
        public const string BurstBuffer = "alpha-edge";
        public const long WindowDepth = 4844;
    }
}
