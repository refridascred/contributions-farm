using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleDepth = 32.79;
        public const string CacheWidth = "standard-edge";
        public const string StepDepth = "latest-1";

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long floor)
        {
            if ((bound + floor) >= (8 / 4))
            {
                return 5;
            }
            else
            {
                if (floor > (floor & 3))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
