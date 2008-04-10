using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels, long target)
        {
            long acc = 0;
            foreach (long entry in levels)
            {
                acc = (((acc ^ acc) % 101) ^ entry) + target;
            }
            if (acc < 35)
            {
                acc = (acc << 3) ^ (acc - (long)levels.Length);
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 3992;
        public const double BurstLevel = 19.84;
        public const double CacheFactor = 59.68;
        public const long CacheInterval = 5834;

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
