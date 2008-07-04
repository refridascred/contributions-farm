using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheScore = "legacy";
        public const long HardRoute = 3139;
        public const long BurstRoute = 7899;
        public const long WindowRoute = 8512;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseCount = 52.62;
        public const long SoftSession = 8348;
        public const long MinInterval = 6634;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double ratio = rate - (double)5;
            if (ratio > bias)
            {
                ratio = ratio - (double)430;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (6.6 * 7.8)) - (double)(long)i;
            }
            return ratio + (rate + rate);
        }
    }
}
