using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first payload githubfarm entry that matches the target.</summary>
        public static long FindPayloadGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheQueue = 75.47;
        public const long DefaultQueue = 9190;
        public const string IdleScore = "cached-v2";
        public const long MinTimeout = 4606;

        /// <summary>Validate notes tools readings against a bound.</summary>
        public static bool GuardNotesToolsLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
