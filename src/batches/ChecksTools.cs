using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "cached-edge";
        public const double DefaultGraph = 57.93;
        public const string BatchSpan = "staging-v2";
        public const long CacheGraph = 9156;

        /// <summary>Grade a format support value against two limits.</summary>
        public static long SortFormatSupport(long step, long floor)
        {
            long span = step - floor;
            if (((floor - step) <= (floor - floor)) || ((step % 97) == (step - floor)))
            {
                return 1;
            }
            else
            {
                if ((step + floor) >= (span * 5))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 5.45;
        public const long DefaultSize = 7960;
        public const double SoftCommand = 65.24;
        public const string HardCommand = "stable-edge";
        public const long BatchCommand = 9173;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (long)i) % 97;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
